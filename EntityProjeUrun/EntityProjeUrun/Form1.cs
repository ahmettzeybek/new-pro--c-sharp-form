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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.tblkategori
                                        select new
                                        {
                                            x.ID,
                                            x.AD
                                        }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tblkategori t = new tblkategori();
            t.AD = txtAd.Text;
            db.tblkategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı Bir Şekilde Yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var ktg = db.tblkategori.Find(x);
            db.tblkategori.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı Bir Şekilde Yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var ktg = db.tblkategori.Find(x);
            ktg.AD = txtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı Bir Şekilde Yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            Hide();
        }
    }
}
