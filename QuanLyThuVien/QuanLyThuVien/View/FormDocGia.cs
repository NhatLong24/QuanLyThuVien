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
        TTN_QuanLyThuVienEntities1 db = new TTN_QuanLyThuVienEntities1();
        public FormDocGia()
        {
            InitializeComponent();
        }
        void HienDSDocGia(List<SINHVIEN> listDocGia)
        {

        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {

        }
    }
}
