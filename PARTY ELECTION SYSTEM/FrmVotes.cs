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
    public partial class FrmVotes : Form
    {
        public FrmVotes()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KTQ0A71;Initial Catalog=DbVoteSystem;Integrated Security=True");

        private void BtnVote_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tblcounty (countyname,aparty,bparty,cparty,dparty,eparty) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", TxtCounty.Text);
            command.Parameters.AddWithValue("@p2", TxtA.Text);
            command.Parameters.AddWithValue("@p3", TxtB.Text);
            command.Parameters.AddWithValue("@p4", tXTc.Text);
            command.Parameters.AddWithValue("@p5", TxtD.Text);
            command.Parameters.AddWithValue("@p6", TxtE.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Voted!!!!!");
        }

        private void BtnGraphics_Click(object sender, EventArgs e)
        {
            FrmGraphics FR = new FrmGraphics();
            FR.Show();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
