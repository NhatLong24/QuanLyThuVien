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
    public partial class FormDauSach : Form
    {
        TTN_QuanLyThuVienEntities1 db = new TTN_QuanLyThuVienEntities1();
        public FormDauSach()
        {
            InitializeComponent();
        }
        void hienthi(List<DAUSACH> dsDauSach)
        {
            ListSach.Items.Clear();
            foreach (DAUSACH ds in dsDauSach)
            {
                ListViewItem item = new ListViewItem(ds.MaSach.ToString());
                item.SubItems.Add(ds.MaTheLoai);
                item.SubItems.Add(ds.MaNhaXuatBan.ToString());
                item.SubItems.Add(ds.MaTacGia.ToString());
                item.SubItems.Add(ds.TenSach);
                item.SubItems.Add(ds.SoLuong.ToString());

                ListSach.Items.Add(item);
            }
            cboTheLoaI.DataSource = db.THELOAIs.ToList();
            cboTheLoaI.DisplayMember = "TenTheLoai";
            cboTheLoaI.ValueMember = "MaTheLoai";
            cboNXB.DataSource = db.NHAXUATBANs.ToList();
            cboNXB.DisplayMember = "TenNhaXuatBan";
            cboNXB.ValueMember = "MaNhaXuatBan";
            cboTG.DataSource = db.TACGIAs.ToList();
            cboTG.DisplayMember = "TenTacGia";
            cboTG.ValueMember = "MaTacGia";

        }
        private void FormDauSach_Load(object sender, EventArgs e)
        {
            List<DAUSACH> lstDS = db.DAUSACHes.ToList();
            hienthi(lstDS);
            
        }

        private void ListPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListSach.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = ListSach.SelectedItems[0];
                tBMaSach.Text = itemSelected.SubItems[0].Text;
                cboTheLoaI.SelectedValue = itemSelected.SubItems[1].Text;
                cboNXB.SelectedValue = itemSelected.SubItems[2].Text;
                cboTG.SelectedValue = itemSelected.SubItems[3].Text;
                TbTenSach.Text = itemSelected.SubItems[4].Text;
                tbSoLuong.Text = itemSelected.SubItems[5].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DAUSACH book = new DAUSACH()
                {
                    MaSach = tBMaSach.Text,
                    MaTheLoai = cboTheLoaI.SelectedValue.ToString(),
                    MaNhaXuatBan = cboNXB.SelectedValue.ToString(),
                    MaTacGia = cboTG.SelectedValue.ToString(),
                    TenSach = TbTenSach.Text,
                    SoLuong = int.Parse(tbSoLuong.Text),
                };
                db.DAUSACHes.Add(book);
                db.SaveChanges();
                FormDauSach_Load(sender,e);
                MessageBox.Show("them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DAUSACH book  = db.DAUSACHes.Find(tBMaSach.Text);
                book.MaTheLoai = cboTheLoaI.SelectedValue.ToString();
                book.MaNhaXuatBan = cboNXB.SelectedValue.ToString();
                book.MaTacGia = cboTG.SelectedValue.ToString();
                book.TenSach = TbTenSach.Text;
                book.SoLuong = int.Parse(tbSoLuong.Text);
                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                FormDauSach_Load(sender, e);
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DAUSACH book = db.DAUSACHes.Find(tBMaSach.Text);
                db.DAUSACHes.Remove(book);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                FormDauSach_Load(sender, e);
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }
        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FormDauSach_Load(sender, e);
            }
            else
            {
                List<DAUSACH> lstKQ = db.DAUSACHes.Where(x => x.TenSach.Contains(txtTimKiem.Text)).ToList();
                if (lstKQ.Count == 0)
                {
                    FormDauSach_Load(sender, e);
                }
                else
                {
                    hienthi(lstKQ);
                }
            }
        }
    }
}
