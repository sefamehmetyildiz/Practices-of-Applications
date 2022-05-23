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

namespace Practices_of_Applications
{
    public partial class FrmStudentPanel : Form
    {
        public FrmStudentPanel()
        {
            InitializeComponent();
        }
        public string number;
        //Data Source=DESKTOP-KTQ0A71;Initial Catalog=DbMarkRecord;Integrated Security=True
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KTQ0A71;Initial Catalog=DbMarkRecord;Integrated Security=True");

        private void FrmStudentPanel_Load(object sender, EventArgs e)
        {
            LblNumber.Text = number;
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from tbllesson where studentnum=@p1", connection);
            command.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblEx1.Text = dr[4].ToString();
                LblEx2.Text = dr[5].ToString();
                LblAvarage.Text = dr[6].ToString();
                LblStatus.Text = dr[7].ToString();
            }
            connection.Close();
        }
    }
}
