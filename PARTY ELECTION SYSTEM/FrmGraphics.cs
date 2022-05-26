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


namespace PARTY_ELECTION_SYSTEM
{
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KTQ0A71;Initial Catalog=DbVoteSystem;Integrated Security=True");

        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            //İLÇE ADLARINI COMBOBOXA ÇEKME
            connection.Open();
            SqlCommand command = new SqlCommand("select Countyname from tblcounty", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            connection.Close();

            //GRAFİĞE TOPLAM SONUÇLARI ÇEKME
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select sum(aparty),sum(bparty),sum(cparty),sum(dparty),sum(eparty) from tblcounty ", connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["PARTIES"].Points.AddXY("A PARTY", dr2[0]);
                chart1.Series["PARTIES"].Points.AddXY("B PARTY", dr2[1]);
                chart1.Series["PARTIES"].Points.AddXY("C PARTY", dr2[2]);
                chart1.Series["PARTIES"].Points.AddXY("D PARTY", dr2[3]);
                chart1.Series["PARTIES"].Points.AddXY("E PARTY", dr2[4]);
            }
            connection.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command3 = new SqlCommand("select * from tblcounty where countyname=@p1", connection);
            command3.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                progressBar1.Value = int.Parse(dr3[2].ToString());
                progressBar2.Value = int.Parse(dr3[3].ToString());
                progressBar3.Value = int.Parse(dr3[4].ToString());
                progressBar4.Value = int.Parse(dr3[5].ToString());
                progressBar5.Value = int.Parse(dr3[6].ToString());
                LblA.Text = dr3[2].ToString();
                LblB.Text = dr3[3].ToString();
                LblC.Text = dr3[4].ToString();
                LblD.Text = dr3[5].ToString();
                LblE.Text = dr3[6].ToString();

            }
            connection.Close();
        }
    }
}
