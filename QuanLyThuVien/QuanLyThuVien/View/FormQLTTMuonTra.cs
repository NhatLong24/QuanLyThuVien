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
    public partial class FormQLTTMuonTra : Form
    {
        TTN_QuanLyThuVienEntities1 db = new TTN_QuanLyThuVienEntities1();
        public FormQLTTMuonTra()
        {
            InitializeComponent();
        }

        private void FormQLTTMuonTra_Load(object sender, EventArgs e)
        {
            List<MUONTRA> DsMT = db.MUONTRAs.ToList();
            foreach (MUONTRA sach in DsMT)
            {
                ListViewItem item = new ListViewItem(sach.MaMuonTra.ToString());
                item.SubItems.Add(sach.MaThe.ToString());
                item.SubItems.Add(sach.MaNhanVien.ToString());
                item.SubItems.Add(sach.NgayMuon.ToString());
                item.SubItems.Add(sach.NgayTra.ToString());
              //  item.SubItems.Add(sach.Ghichu.ToString());

                listDsMuonTra.Items.Add(item);
            }
            cbMaThe.DataSource = db.THETHUVIENs.ToList();
            cbMaThe.DisplayMember = "MaThe";
            cbMaThe.ValueMember = "MaThe";

            cbMaNV.DataSource = db.NHANVIENs.ToList();
            cbMaNV.DisplayMember = "MaNhanVien";
            cbMaNV.ValueMember = "MaNhanVien";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                MUONTRA mt = new MUONTRA()
                {
                    MaMuonTra = txtMaMuonTra.Text,
                    MaThe = cbMaThe.Text,
                    MaNhanVien = cbMaNV.Text,
                    NgayMuon = datemuon.Value,
                    NgayTra = datetra.Value,
                    //CMND = int.Parse(txtCMND.Text),
                    Ghichu = txtGhiChu.Text
                };
                db.MUONTRAs.Add(mt);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                listDsMuonTra.Items.Clear();
                FormQLTTMuonTra_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
            /*try
            {
                SqlParameter[] idparam =
                {
                    new SqlParameter { ParameterName = "MaMuonTra", Value = txtMaMuonTra.Text },
                    new SqlParameter { ParameterName = "MaThe", Value = cbMaThe.Text},
                    new SqlParameter { ParameterName = "MaNhanVien", Value = cbMaNV.Text},
                    new SqlParameter { ParameterName = "NgayMuon", Value = datemuon.Value},
                    new SqlParameter { ParameterName = "NgayTra", Value = datetra.Value},
                    new SqlParameter { ParameterName = "Ghichu", Value =txtGhiChu.Text}
                };
                db.Database.ExecuteSqlCommand("Them @MaMuonTra,@MaThe, @MaNhanVien,@NgayMuon,@NgayTra,@Ghichu ", idparam);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                listDsMuonTra.Items.Clear();
                ThemttMuonTra_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }*/
        }

        private void listDsMuonTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDsMuonTra.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listDsMuonTra.SelectedItems[0];
                txtMaMuonTra.Text = itemSelected.SubItems[0].Text;
                cbMaThe.Text = itemSelected.SubItems[1].Text;
                cbMaNV.Text = itemSelected.SubItems[2].Text;
                datemuon.Text = itemSelected.SubItems[3].Text;
                datetra.Text = itemSelected.SubItems[4].Text;
               // txtGhiChu.Text = itemSelected.SubItems[5].Text;


            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            /*  try
             {
                 MUONTRA mt = db.MUONTRAs.Find(int.Parse(txtMaMuonTra.Text));
                 mt.MaThe = cbMaThe.Text;
                 mt.MaNhanVien = cbMaNV.Text;
                 mt.NgayMuon = datemuon.Value;
                 mt.NgayTra = datetra.Value;
                 mt.Ghichu = txtGhiChu.Text;
                 SqlParameter[] idparam =
                 {
                     new SqlParameter { ParameterName = "MaMuonTra", Value = txtMaMuonTra.Text },
                     new SqlParameter { ParameterName = "MaThe", Value = cbMaThe.Text},
                     new SqlParameter { ParameterName = "MaNhanVien", Value = cbMaNV.Text},
                     new SqlParameter { ParameterName = "NgayMuon", Value = datemuon.Value},
                     new SqlParameter { ParameterName = "NgayTra", Value = datetra.Value},
                     new SqlParameter { ParameterName = "Ghichu", Value =txtGhiChu.Text}
                 };
                 db.Database.ExecuteSqlCommand("Sua @MaMuonTra,@MaThe, @MaNhanVien,@NgayMuon,@NgayTra,@Ghichu  ", idparam);

                 db.SaveChanges();
                 MessageBox.Show("Sua thanh cong");
                 listDsMuonTra.Items.Clear();
                 ThemttMuonTra_Load(sender, e);

             }
             catch (Exception ex)
             {
                 MessageBox.Show("" + ex.Message);
             }*/
            MUONTRA gv = new MUONTRA();
            try
            {

                gv = db.MUONTRAs.Find(int.Parse(txtMaMuonTra.ToString()));
                gv.MaThe = cbMaThe.ToString();
                gv.MaNhanVien = cbMaNV.ToString();
                gv.NgayMuon = datemuon.Value;
                gv.NgayTra = datetra.Value;
                gv.Ghichu = txtGhiChu.ToString();

                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                FormQLTTMuonTra_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            /*  try
              {
                  MUONTRA mt = db.MUONTRAs.Find(int.Parse(txtMaMuonTra.Text));
                  SqlParameter idparam = new SqlParameter { ParameterName = "MaMuonTra", Value = mt.MaMuonTra };
                  db.Database.ExecuteSqlCommand("Xoa @MaMuonTra ", idparam);
                  db.SaveChanges();
                  MessageBox.Show("Xóa Thành Công");
                  listDsMuonTra.Items.Clear();
                  ThemttMuonTra_Load(sender, e);


              }
              catch (Exception ex)
              { MessageBox.Show("" + ex.Message); } */
            try
            {

                MUONTRA mt = db.MUONTRAs.Find(int.Parse(txtMaMuonTra.Text));
                db.MUONTRAs.Remove(mt);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                listDsMuonTra.Items.Clear();
                FormQLTTMuonTra_Load(sender, e);
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            TimkiemttmuonTra f = new TimkiemttmuonTra();
            f.Show();
            this.Hide();
        }
    }
}
