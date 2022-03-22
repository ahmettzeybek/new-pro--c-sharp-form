using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUrun
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.tblurun
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.tblkategori.AD,
                                            x.DURUM
                                        }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tblurun t = new tblurun();
            t.URUNAD = txtad.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.MARKA = txtmarka.Text;
            t.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            t.DURUM = true;
            db.tblurun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı Bir Şekilde Yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var urun = db.tblurun.Find(x);
            db.tblurun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı Bir Şekilde Yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var t = db.tblurun.Find(x);
            t.URUNAD = txtad.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.MARKA = txtmarka.Text;
            t.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            t.DURUM = true;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı Bir Şekilde Yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.tblkategori
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            Hide();
        }
    }
}
