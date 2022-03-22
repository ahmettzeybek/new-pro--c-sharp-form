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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmUrun fr = new FrmUrun();
            fr.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Frmistatistik frm = new Frmistatistik();
            frm.Show();
            this.Hide();
        }
    }
}
