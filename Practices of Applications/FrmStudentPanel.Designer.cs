
namespace Practices_of_Applications
{
    partial class FrmStudentPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblEx2 = new System.Windows.Forms.Label();
            this.LblAvarage = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.LblEx1 = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exam2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Avarage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Exam1:";
            // 
            // LblEx2
            // 
            this.LblEx2.AutoSize = true;
            this.LblEx2.Location = new System.Drawing.Point(146, 136);
            this.LblEx2.Name = "LblEx2";
            this.LblEx2.Size = new System.Drawing.Size(28, 18);
            this.LblEx2.TabIndex = 9;
            this.LblEx2.Text = "00";
            // 
            // LblAvarage
            // 
            this.LblAvarage.AutoSize = true;
            this.LblAvarage.Location = new System.Drawing.Point(146, 172);
            this.LblAvarage.Name = "LblAvarage";
            this.LblAvarage.Size = new System.Drawing.Size(28, 18);
            this.LblAvarage.TabIndex = 8;
            this.LblAvarage.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Status:";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(146, 24);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(52, 18);
            this.LblNameSurname.TabIndex = 12;
            this.LblNameSurname.Text = "NULL";
            // 
            // LblEx1
            // 
            this.LblEx1.AutoSize = true;
            this.LblEx1.Location = new System.Drawing.Point(146, 98);
            this.LblEx1.Name = "LblEx1";
            this.LblEx1.Size = new System.Drawing.Size(28, 18);
            this.LblEx1.TabIndex = 11;
            this.LblEx1.Text = "00";
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(146, 62);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(48, 18);
            this.LblNumber.TabIndex = 10;
            this.LblNumber.Text = "0000";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(146, 210);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(52, 18);
            this.LblStatus.TabIndex = 13;
            this.LblStatus.Text = "NULL";
            // 
            // FrmStudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 250);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblNameSurname);
            this.Controls.Add(this.LblEx1);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.LblEx2);
            this.Controls.Add(this.LblAvarage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudentPanel";
            this.Text = "STUDENT PANEL";
            this.Load += new System.EventHandler(this.FrmStudentPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblEx2;
        private System.Windows.Forms.Label LblAvarage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label LblEx1;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblStatus;
    }
}