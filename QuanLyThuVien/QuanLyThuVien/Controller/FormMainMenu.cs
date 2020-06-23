using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.View;

namespace QuanLyThuVien.Controller
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void themToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormThemDocGia ftdg = new FormThemDocGia();
            this.Hide();
            ftdg.ShowDialog();
        }

        private void buttonDocGia_Click(object sender, EventArgs e)
        {
            FormDocGia fdg = new FormDocGia();
            this.Hide();
            fdg.Show();
        }
    }
}
