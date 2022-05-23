
namespace Practices_of_Applications
{
    partial class FrmTeacherPanel
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.MskNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEx1 = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtEx2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblFailed = new System.Windows.Forms.Label();
            this.LblPassed = new System.Windows.Forms.Label();
            this.LblAvg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbMarkRecordDataSet = new Practices_of_Applications.DbMarkRecordDataSet();
            this.tBLLESSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLLESSONTableAdapter = new Practices_of_Applications.DbMarkRecordDataSetTableAdapters.TBLLESSONTableAdapter();
            this.sTUDENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTEX1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTEX2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVARAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMarkRecordDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLESSONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.MskNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD STUDENT";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(116, 189);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(149, 32);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "SAVE STUDENT";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "SURNAME:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(116, 157);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(149, 26);
            this.TxtSurname.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(116, 105);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(149, 26);
            this.TxtName.TabIndex = 3;
            // 
            // MskNumber
            // 
            this.MskNumber.Location = new System.Drawing.Point(116, 53);
            this.MskNumber.Mask = "0000";
            this.MskNumber.Name = "MskNumber";
            this.MskNumber.Size = new System.Drawing.Size(149, 26);
            this.MskNumber.TabIndex = 2;
            this.MskNumber.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMBER:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEx1);
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Controls.Add(this.TxtEx2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(286, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exams Grades";
            // 
            // TxtEx1
            // 
            this.TxtEx1.Location = new System.Drawing.Point(95, 53);
            this.TxtEx1.Name = "TxtEx1";
            this.TxtEx1.Size = new System.Drawing.Size(149, 26);
            this.TxtEx1.TabIndex = 7;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(56, 153);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(149, 32);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtEx2
            // 
            this.TxtEx2.Location = new System.Drawing.Point(95, 105);
            this.TxtEx2.Name = "TxtEx2";
            this.TxtEx2.Size = new System.Drawing.Size(149, 26);
            this.TxtEx2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "EXAM 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "EXAM 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblFailed);
            this.groupBox3.Controls.Add(this.LblPassed);
            this.groupBox3.Controls.Add(this.LblAvg);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(554, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exams Grades";
            // 
            // LblFailed
            // 
            this.LblFailed.AutoSize = true;
            this.LblFailed.Location = new System.Drawing.Point(140, 165);
            this.LblFailed.Name = "LblFailed";
            this.LblFailed.Size = new System.Drawing.Size(28, 18);
            this.LblFailed.TabIndex = 8;
            this.LblFailed.Text = "00";
            // 
            // LblPassed
            // 
            this.LblPassed.AutoSize = true;
            this.LblPassed.Location = new System.Drawing.Point(140, 113);
            this.LblPassed.Name = "LblPassed";
            this.LblPassed.Size = new System.Drawing.Size(28, 18);
            this.LblPassed.TabIndex = 7;
            this.LblPassed.Text = "00";
            // 
            // LblAvg
            // 
            this.LblAvg.AutoSize = true;
            this.LblAvg.Location = new System.Drawing.Point(140, 61);
            this.LblAvg.Name = "LblAvg";
            this.LblAvg.Size = new System.Drawing.Size(28, 18);
            this.LblAvg.TabIndex = 6;
            this.LblAvg.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "FAİLED:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "PASSED:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "AVERAGE:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(4, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(821, 230);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EXAMS INFORMATIONS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUDENTIDDataGridViewTextBoxColumn,
            this.sTUDENTNUMDataGridViewTextBoxColumn,
            this.sTUDENTNAMEDataGridViewTextBoxColumn,
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn,
            this.sTUDENTEX1DataGridViewTextBoxColumn,
            this.sTUDENTEX2DataGridViewTextBoxColumn,
            this.aVARAGEDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLLESSONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(815, 205);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dbMarkRecordDataSet
            // 
            this.dbMarkRecordDataSet.DataSetName = "DbMarkRecordDataSet";
            this.dbMarkRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLLESSONBindingSource
            // 
            this.tBLLESSONBindingSource.DataMember = "TBLLESSON";
            this.tBLLESSONBindingSource.DataSource = this.dbMarkRecordDataSet;
            // 
            // tBLLESSONTableAdapter
            // 
            this.tBLLESSONTableAdapter.ClearBeforeFill = true;
            // 
            // sTUDENTIDDataGridViewTextBoxColumn
            // 
            this.sTUDENTIDDataGridViewTextBoxColumn.DataPropertyName = "STUDENTID";
            this.sTUDENTIDDataGridViewTextBoxColumn.HeaderText = "STUDENTID";
            this.sTUDENTIDDataGridViewTextBoxColumn.Name = "sTUDENTIDDataGridViewTextBoxColumn";
            this.sTUDENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUDENTNUMDataGridViewTextBoxColumn
            // 
            this.sTUDENTNUMDataGridViewTextBoxColumn.DataPropertyName = "STUDENTNUM";
            this.sTUDENTNUMDataGridViewTextBoxColumn.HeaderText = "STUDENTNUM";
            this.sTUDENTNUMDataGridViewTextBoxColumn.Name = "sTUDENTNUMDataGridViewTextBoxColumn";
            // 
            // sTUDENTNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENTNAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENTNAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.Name = "sTUDENTNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTSURNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENTSURNAME";
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENTSURNAME";
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.Name = "sTUDENTSURNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTEX1DataGridViewTextBoxColumn
            // 
            this.sTUDENTEX1DataGridViewTextBoxColumn.DataPropertyName = "STUDENTEX1";
            this.sTUDENTEX1DataGridViewTextBoxColumn.HeaderText = "STUDENTEX1";
            this.sTUDENTEX1DataGridViewTextBoxColumn.Name = "sTUDENTEX1DataGridViewTextBoxColumn";
            // 
            // sTUDENTEX2DataGridViewTextBoxColumn
            // 
            this.sTUDENTEX2DataGridViewTextBoxColumn.DataPropertyName = "STUDENTEX2";
            this.sTUDENTEX2DataGridViewTextBoxColumn.HeaderText = "STUDENTEX2";
            this.sTUDENTEX2DataGridViewTextBoxColumn.Name = "sTUDENTEX2DataGridViewTextBoxColumn";
            // 
            // aVARAGEDataGridViewTextBoxColumn
            // 
            this.aVARAGEDataGridViewTextBoxColumn.DataPropertyName = "AVARAGE";
            this.aVARAGEDataGridViewTextBoxColumn.HeaderText = "AVARAGE";
            this.aVARAGEDataGridViewTextBoxColumn.Name = "aVARAGEDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewCheckBoxColumn
            // 
            this.sTATUSDataGridViewCheckBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.Name = "sTATUSDataGridViewCheckBoxColumn";
            // 
            // FrmTeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(823, 489);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTeacherPanel";
            this.Text = "Teacher Panel";
            this.Load += new System.EventHandler(this.FrmTeacherPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMarkRecordDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLESSONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.MaskedTextBox MskNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtEx1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtEx2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblFailed;
        private System.Windows.Forms.Label LblPassed;
        private System.Windows.Forms.Label LblAvg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbMarkRecordDataSet dbMarkRecordDataSet;
        private System.Windows.Forms.BindingSource tBLLESSONBindingSource;
        private DbMarkRecordDataSetTableAdapters.TBLLESSONTableAdapter tBLLESSONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTEX1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTEX2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVARAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATUSDataGridViewCheckBoxColumn;
    }
}