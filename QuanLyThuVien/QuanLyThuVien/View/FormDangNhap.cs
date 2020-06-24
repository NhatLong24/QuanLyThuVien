using QuanLyThuVien.Controller;
using QuanLyThuVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.View
{
    public partial class FormDangNhap : Form
    {
        TTN_QuanLyThuVienEntities1 db = new TTN_QuanLyThuVienEntities1();
        public FormDangNhap()
        {
            InitializeComponent();
            textBoxMK.PasswordChar = '*';
        }


        private void buttonDangky_Click(object sender, EventArgs e)
        {
            FormDangKy fdk = new FormDangKy();
            this.Hide();
            fdk.ShowDialog();
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxTK.Text))
                {
                    MessageBox.Show("Ban chua nhap ten tai khoan!!");
                    this.ActiveControl = textBoxTK;
                }
                else if (String.IsNullOrEmpty(textBoxMK.Text))
                {
                    MessageBox.Show("Ban chua nhap mat khau!!");
                    this.ActiveControl = textBoxMK;
                }
                else
                {
                    NguoiDung ndCheck = db.NguoiDungs.SingleOrDefault(x => x.TenUser == textBoxTK.Text && x.MatKhau == textBoxMK.Text);
                    if (ndCheck != null)
                    {
                        FormMainMenu formMain = new FormMainMenu();
                        formMain.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tai khoan hoac mat khau sai!!");
                        textBoxTK.Clear();
                        textBoxMK.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
