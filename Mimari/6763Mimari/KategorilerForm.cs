using Mimari.Entity;
using Mimari.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6763Mimari
{
    public partial class KategorilerForm : Form
    {
        public KategorilerForm()
        {
            InitializeComponent();
        }

        private void KategorilerForm_Load(object sender, EventArgs e)
        {
            Listele();

        }
        KategorilerORM orm = new KategorilerORM();
        private void Listele()
        {
            orm.Sil(14);
            dataGridView1.DataSource = orm.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategoriler kg = new Kategoriler();
            kg.KategoriAdi = txtAdi.Text;
            kg.Tanimi = txtTanimi.Text;
            kg.Resim = new byte[0];
            orm.Ekle(kg);
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Kategoriler kg = new Kategoriler();
            orm.Guncelle(kg);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@KategoriID", dataGridView1.CurrentRow.Cells["KategoriID"].Value);
            cmd.Parameters.AddWithValue("@KategoriAdi", dataGridView1.CurrentRow.Cells["KategoriAdi"].Value);
            cmd.Parameters.AddWithValue("@Tanimi", dataGridView1.CurrentRow.Cells["Tanimi"].Value);
            cmd.Parameters.AddWithValue("@Resim", dataGridView1.CurrentRow.Cells["Resim"].Value);
        }
    }
}
