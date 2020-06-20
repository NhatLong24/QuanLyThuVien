using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.Model;

namespace QuanLyThuVien.View
{
    public partial class FormDocGia : Form
    {
        TTN_QuanLyThuVienEntities db = new TTN_QuanLyThuVienEntities();
        private string maTheTV;
        private string maSV;
        public FormDocGia()
        {
            InitializeComponent();
        }
        void HienDSDocGia(List<SINHVIEN> listDocGia)
        {
            listViewSV.Items.Clear();
            foreach(SINHVIEN sv in listDocGia)
            {
                ListViewItem newItem = new ListViewItem(sv.MaSinhVien);
                newItem.SubItems.Add(sv.HoTen);
                THETHUVIEN ttv = db.THETHUVIENs.Single(x => x.MaSinhVien == sv.MaSinhVien);
                newItem.SubItems.Add(ttv.MaThe);
                newItem.SubItems.Add(ttv.NgayHetHan.Value.ToString("yyyy/MM/dd"));
                newItem.SubItems.Add(sv.NgaySinh.Value.ToString("yyyy/MM/dd"));
                newItem.SubItems.Add(sv.Gioitinh);
                newItem.SubItems.Add(sv.SoDienThoai.Value.ToString());
                listViewSV.Items.Add(newItem);
            }
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            List<SINHVIEN> lstSV = db.SINHVIENs.ToList();
            HienDSDocGia(lstSV);
        }

        private void listViewSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewSV.SelectedItems.Count>0)
            {
                ListViewItem selectedItem = listViewSV.SelectedItems[0];
                maSV= selectedItem.SubItems[0].Text;
                txtTenSV.Text = selectedItem.SubItems[1].Text;
                maTheTV= selectedItem.SubItems[2].Text;
                txtMaThe.Text = maTheTV;
                dtNgayHetHanThe.Value = DateTime.Parse(selectedItem.SubItems[3].Text);
                dtNgaySinh.Value = DateTime.Parse(selectedItem.SubItems[4].Text);
                txtGioiTinh.Text= selectedItem.SubItems[5].Text;
                txtSDT.Text= selectedItem.SubItems[6].Text;
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn sửa thông tin của người được chọn không?","Thông báo",MessageBoxButtons.YesNo)
                ==System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    SINHVIEN sv = db.SINHVIENs.Single(x => x.MaSinhVien == maSV);
                    sv.NgaySinh = dtNgaySinh.Value;
                    sv.Gioitinh = txtGioiTinh.Text;
                    sv.SoDienThoai = int.Parse(txtSDT.Text);
                    sv.HoTen = txtTenSV.Text;
                    THETHUVIEN ttv = db.THETHUVIENs.Single(x => x.MaThe == maTheTV);
                    ttv.NgayHetHan = dtNgayHetHanThe.Value;
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công!");
                    FormDocGia_Load(sender, e);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }

            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin của người được chọn không?", "Thông báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    THETHUVIEN ttv = db.THETHUVIENs.Single(x => x.MaThe == maTheTV);
                    ttv.MaSinhVien = null;
                    SINHVIEN sv = db.SINHVIENs.Single(x => x.MaSinhVien == maSV);
                    db.SINHVIENs.Remove(sv);
                    
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công!");
                    FormDocGia_Load(sender, e);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtTimKiem.Text=="")
            {
                FormDocGia_Load(sender, e);
            }
            else
            {
                List<SINHVIEN> lstKQ = db.SINHVIENs.Where(x => x.HoTen.Contains(txtTimKiem.Text)).ToList();
                if(lstKQ.Count==0)
                {
                    FormDocGia_Load(sender, e);
                }
                else
                {
                    HienDSDocGia(lstKQ);
                }
            }
        }
    }
}
