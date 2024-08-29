namespace Nationals_Project_1_1126
{
    partial class Skills_USA_Payroll
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvOutput = new DataGridView();
            btnRefresh = new Button();
            btnExit = new Button();
            btnChoose = new Button();
            btnClear = new Button();
            lblOranization = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOutput).BeginInit();
            SuspendLayout();
            // 
            // dgvOutput
            // 
            dgvOutput.AllowUserToAddRows = false;
            dgvOutput.AllowUserToDeleteRows = false;
            dgvOutput.AllowUserToResizeColumns = false;
            dgvOutput.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutput.Location = new Point(24, 25);
            dgvOutput.Name = "dgvOutput";
            dgvOutput.ReadOnly = true;
            dgvOutput.RowHeadersWidth = 92;
            dgvOutput.Size = new Size(2340, 837);
            dgvOutput.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(321, 901);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(258, 61);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "&Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(922, 901);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(258, 61);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(24, 901);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(258, 61);
            btnChoose.TabIndex = 3;
            btnChoose.Text = "&Choose File";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(621, 901);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(258, 61);
            btnClear.TabIndex = 4;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblOranization
            // 
            lblOranization.AutoSize = true;
            lblOranization.Location = new Point(2077, 901);
            lblOranization.Name = "lblOranization";
            lblOranization.Size = new Size(287, 37);
            lblOranization.TabIndex = 5;
            lblOranization.Text = "SkillsUSA Organization";
            // 
            // Skills_USA_Payroll
            // 
            AcceptButton = btnRefresh;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(2431, 994);
            Controls.Add(lblOranization);
            Controls.Add(btnClear);
            Controls.Add(btnChoose);
            Controls.Add(btnExit);
            Controls.Add(btnRefresh);
            Controls.Add(dgvOutput);
            Name = "Skills_USA_Payroll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SkillsUSA Payroll";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOutput;
        private Button btnRefresh;
        private Button btnExit;
        private Button btnChoose;
        private Button btnClear;
        private Label lblOranization;
    }
}
