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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.tblkategori.Count().ToString();
            labelControl3.Text = db.tblurun.Count().ToString();
            labelControl5.Text = db.tblmusteri.Count(x => x.DURUM == true).ToString();
            labelControl7.Text = db.tblmusteri.Count(x => x.DURUM == false).ToString();
            labelControl13.Text = db.tblurun.Sum(x => x.STOK).ToString();
            labelControl21.Text = db.tblsatis.Sum(x => x.FIYAT).ToString()+ " TL";
            labelControl11.Text = (from x in db.tblurun orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            labelControl9.Text = (from x in db.tblurun orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            labelControl15.Text = db.tblurun.Count(x => x.URUNAD =="BUZDOLABI").ToString();
            labelControl17.Text = db.tblkategori.Count(x => x.ID == 2).ToString();
            labelControl23.Text = (from x in db.tblmusteri select x.SEHIR).Distinct().Count().ToString();
            labelControl19.Text = db.MARKAGETIR().FirstOrDefault();
        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            Hide();
        }
    }
}
