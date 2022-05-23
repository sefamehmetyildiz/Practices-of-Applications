using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practices_of_Applications
{
    public partial class FrmStudentLogin : Form
    {
        public FrmStudentLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmStudentPanel FR = new FrmStudentPanel();
            FR.number = MskStudentNumber.Text;
            FR.Show();
            this.Hide();
            
        }

        private void MskStudentNumber_TextChanged(object sender, EventArgs e)
        {
            if (MskStudentNumber.Text == "1111")
            {
                FrmTeacherPanel FR = new FrmTeacherPanel();
                FR.Show();
                this.Hide();
            }
        }
    }
}
