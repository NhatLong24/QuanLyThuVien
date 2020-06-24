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
    public partial class TimkiemttmuonTra : Form
    {
        TTN_QuanLyThuVienEntities1 db = new TTN_QuanLyThuVienEntities1();
        public TimkiemttmuonTra()
        {
            InitializeComponent();
        }

        private void TimkiemttmuonTra_Load(object sender, EventArgs e)
        {
            List<MUONTRA> dsMT = db.MUONTRAs.ToList();
            HienThi(dsMT);
        }
        void HienThi(List<MUONTRA> dsMT)
        {
            listDsMuonTra.Items.Clear();
            foreach (MUONTRA mt in dsMT)
            {
                ListViewItem item = new ListViewItem(mt.MaMuonTra.ToString());
                item.SubItems.Add(mt.MaThe.ToString());
                item.SubItems.Add(mt.MaNhanVien.ToString());
                item.SubItems.Add(mt.NgayMuon.ToString());
                item.SubItems.Add(mt.NgayTra.ToString());
                //item.SubItems.Add(mt.Ghichu.ToString());

                listDsMuonTra.Items.Add(item);
            }
        }

        private void Keypress1(object sender, KeyPressEventArgs e)
        {
            string mamuontra = txtMaMuonTra.Text;
            if (mamuontra == "")
            {
                HienThi(db.MUONTRAs.ToList());
            }
            else
            {
                List<MUONTRA> KetQua = db.MUONTRAs.Where(x => x.MaMuonTra.ToUpper().Contains(mamuontra.ToUpper())).ToList();
                HienThi(KetQua);
            }
        }

        private void Mouseclick1(object sender, MouseEventArgs e)
        {
            txtMaMuonTra.Text = "";
            TimkiemttmuonTra_Load(sender, e);
        }

        private void Keypress2(object sender, KeyPressEventArgs e)
        {
            string mathe = txtMaThe.Text;
            if (mathe == "")
            {
                HienThi(db.MUONTRAs.ToList());
            }
            else
            {
                List<MUONTRA> KetQua = db.MUONTRAs.Where(x => x.MaThe.ToUpper().Contains(mathe.ToUpper())).ToList();
                HienThi(KetQua);
            }
        }

        private void Mouseclick2(object sender, MouseEventArgs e)
        {
            txtMaThe.Text = "";
            TimkiemttmuonTra_Load(sender, e);
        }

        private void Keypress3(object sender, KeyPressEventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            if (maNV == "")
            {
                HienThi(db.MUONTRAs.ToList());
            }
            else
            {
                List<MUONTRA> KetQua = db.MUONTRAs.Where(x => x.MaNhanVien.ToUpper().Contains(maNV.ToUpper())).ToList();
                HienThi(KetQua);
            }
        }

        private void Mouseclick3(object sender, MouseEventArgs e)
        {
            txtMaNhanVien.Text = "";
            TimkiemttmuonTra_Load(sender, e);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            FormQLTTMuonTra a = new FormQLTTMuonTra();
            a.Show();
            this.Hide();
        }
    }
}
