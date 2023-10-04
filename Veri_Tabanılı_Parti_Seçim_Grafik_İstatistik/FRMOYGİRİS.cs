using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veri_Tabanılı_Parti_Seçim_Grafik_İstatistik
{
    public partial class FRMOYGİRİS : Form
    {
        public FRMOYGİRİS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KPC6PV7\SQLEXPRESS;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI)VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1",txtilcead.Text);
            komut.Parameters.AddWithValue("@p2", txta.Text);
            komut.Parameters.AddWithValue("@p3", txtb.Text);
            komut.Parameters.AddWithValue("@p4", txtc.Text);
            komut.Parameters.AddWithValue("@p5", txtd.Text);
            komut.Parameters.AddWithValue("@p6", txte.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("oy girişi gerçekleşti");
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            frmgrafikler FR=new frmgrafikler();
            FR.Show();

        }
    }
}
