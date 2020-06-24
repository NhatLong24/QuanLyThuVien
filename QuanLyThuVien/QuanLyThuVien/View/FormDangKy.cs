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
    public partial class FormDangKy : Form
    {
        TTN_QuanLyThuVienEntities1 db = new TTN_QuanLyThuVienEntities1();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDK_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxTK.Text))
                {
                    MessageBox.Show("Ban chua nhap tai khoan!!");
                    this.ActiveControl = textBoxTK;
                }

                else if (String.IsNullOrEmpty(textBoxTK.Text))
                {
                    MessageBox.Show("Ban chua nhap tai khoan!!");
                    this.ActiveControl = textBoxMK;
                }
                else
                {
                    NguoiDung userCheck = db.NguoiDungs.SingleOrDefault(x => x.TenUser == textBoxTK.Text);
                    if (userCheck == null)
                    {
                        NguoiDung userNew = new NguoiDung()
                        {
                            TenUser = textBoxTK.Text,
                            MatKhau = textBoxMK.Text
                        };

                        db.NguoiDungs.Add(userNew);
                        db.SaveChanges();

                        MessageBox.Show("Dang ky tai khoan thanh cong!!");
                        FormDangNhap fdn = new FormDangNhap();
                        //this.Hide();
                        fdn.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tai khoan da ton tai!!!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
