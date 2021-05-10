using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6763Mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Urunler2Form uf = new Urunler2Form();
        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uf.IsDisposed)
                uf = new Urunler2Form();
            uf.MdiParent = this;
            uf.Show();

        }
        KategorilerForm kf = new KategorilerForm();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kf.IsDisposed)
                kf = new KategorilerForm();
            kf.MdiParent = this;
            kf.Show();
        }
    }

   
}
