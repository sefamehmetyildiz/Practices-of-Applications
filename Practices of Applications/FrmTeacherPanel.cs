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
    public partial class FrmTeacherPanel : Form
    {
        public FrmTeacherPanel()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KTQ0A71;Initial Catalog=DbMarkRecord;Integrated Security=True");

        private void FrmTeacherPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbMarkRecordDataSet.TBLLESSON' table. You can move, or remove it, as needed.
            this.tBLLESSONTableAdapter.Fill(this.dbMarkRecordDataSet.TBLLESSON);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tbllesson (studentnum,studentname,studentsurname) values (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", MskNumber.Text);
            command.Parameters.AddWithValue("@p2", TxtName.Text);
            command.Parameters.AddWithValue("@p3", TxtSurname.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Added");
            this.tBLLESSONTableAdapter.Fill(this.dbMarkRecordDataSet.TBLLESSON);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            MskNumber.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtName.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            TxtEx1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TxtEx2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            double avg, ex1, ex2;
            string status;
            ex1 = Convert.ToDouble(TxtEx1.Text);
            ex2 = Convert.ToDouble(TxtEx2.Text);

            avg = (ex1 + ex2) / 2;
            LblAvg.Text = avg.ToString();
            if (avg >= 50)
            {
                status = "true";
            }
            else
            {
                status = "false";
            }

            connection.Open();
            SqlCommand command = new SqlCommand("update tbllesson set studentex1=@p1 , studentex2=@p2 , avarage=@p4,status=@p5 where studentnum=@p6 ", connection);
            command.Parameters.AddWithValue("@p1", TxtEx1.Text);
            command.Parameters.AddWithValue("@p2", TxtEx2.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(LblAvg.Text));
            command.Parameters.AddWithValue("@p5", status);
            command.Parameters.AddWithValue("@p6", MskNumber.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Updated");
            this.tBLLESSONTableAdapter.Fill(this.dbMarkRecordDataSet.TBLLESSON);



        }
    }
}
