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
    public partial class FormThemDocGia : Form
    {
        TTN_QuanLyThuVienEntities1 db = new TTN_QuanLyThuVienEntities1();
        public FormThemDocGia()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                SINHVIEN sv = new SINHVIEN()
                {
                    MaSinhVien = textBoxMaSV.Text,
                    HoTen = textBoxHoTen.Text,
                    NgaySinh = dateTimePickerNS.Value,
                    Gioitinh = textBoxGT.Text,
                    DiaChi = textBoxDiaChi.Text,
                    SoDienThoai = int.Parse(textBoxSDT.Text),

                };
                db.SINHVIENs.Add(sv);
                db.SaveChanges();

                THETHUVIEN ttv = new THETHUVIEN()
                {

                    MaSinhVien = textBoxMaSV.Text,
                    MaThe = textBoxMaThe.Text,
                    NgayTaoThe = dateTimePickerNgTao.Value,
                    NgayHetHan = dateTimePickerNgHH.Value,
                    NgayGiaHan = dateTimePickerNgGH.Value
                };
                db.THETHUVIENs.Add(ttv);
                db.SaveChanges();

                FormDocGia fdg = new FormDocGia();
                this.Hide();
                fdg.ShowDialog();

                MessageBox.Show("Them thanh cong!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBackToFDG_Click(object sender, EventArgs e)
        {
            FormDocGia fdg = new FormDocGia();
            this.Hide();
            fdg.ShowDialog();
        }
    }
}
