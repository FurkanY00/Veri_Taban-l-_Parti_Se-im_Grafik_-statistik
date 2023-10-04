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
    public partial class frmgrafikler : Form
    {
        public frmgrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KPC6PV7\SQLEXPRESS;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void frmgrafikler_Load(object sender, EventArgs e)
        {
            //ilçe adlarını combobox' a cekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD FROM TBLILCE ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();



            // grafiğe toplam sonucları getirme 
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) FROM TBLILCE",baglanti);
            SqlDataReader dr3=komut3.ExecuteReader();
            while (dr3.Read())
            {
                chart1.Series["partiler"].Points.AddXY("A PARTI", dr3[0]);
                chart1.Series["partiler"].Points.AddXY("B PARTI", dr3[1]);
                chart1.Series["partiler"].Points.AddXY("C PARTI", dr3[2]);
                chart1.Series["partiler"].Points.AddXY("D PARTI", dr3[3]);
                chart1.Series["partiler"].Points.AddXY("E PARTI", dr3[4]);
                baglanti.Close();


            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from TBLILCE where ılcead=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr =komut.ExecuteReader();
            while(dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar1.Value = int.Parse(dr[3].ToString());
                progressBar1.Value = int.Parse(dr[4].ToString());
                progressBar1.Value = int.Parse(dr[5].ToString());
                progressBar1.Value = int.Parse(dr[6].ToString());
            }
            baglanti.Close();

        }
    }
}
