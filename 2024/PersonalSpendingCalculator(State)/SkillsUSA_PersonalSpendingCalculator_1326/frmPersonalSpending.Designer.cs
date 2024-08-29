namespace SkillsUSA_PersonalSpendingCalculator_1326
{
    partial class frmPersonalSpending
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
            this.grpIncomeFrequency = new System.Windows.Forms.GroupBox();
            this.rdoAnnually = new System.Windows.Forms.RadioButton();
            this.rdoBiWeekly = new System.Windows.Forms.RadioButton();
            this.rdoHourly = new System.Windows.Forms.RadioButton();
            this.lstCatagoriesDisplay = new System.Windows.Forms.ListBox();
            this.lblListBox = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpIncomeFrequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIncomeFrequency
            // 
            this.grpIncomeFrequency.Controls.Add(this.rdoAnnually);
            this.grpIncomeFrequency.Controls.Add(this.rdoBiWeekly);
            this.grpIncomeFrequency.Controls.Add(this.rdoHourly);
            this.grpIncomeFrequency.Location = new System.Drawing.Point(25, 32);
            this.grpIncomeFrequency.Name = "grpIncomeFrequency";
            this.grpIncomeFrequency.Size = new System.Drawing.Size(455, 100);
            this.grpIncomeFrequency.TabIndex = 0;
            this.grpIncomeFrequency.TabStop = false;
            this.grpIncomeFrequency.Text = "Income Frequency";
            // 
            // rdoAnnually
            // 
            this.rdoAnnually.AutoSize = true;
            this.rdoAnnually.Location = new System.Drawing.Point(305, 44);
            this.rdoAnnually.Name = "rdoAnnually";
            this.rdoAnnually.Size = new System.Drawing.Size(126, 29);
            this.rdoAnnually.TabIndex = 3;
            this.rdoAnnually.TabStop = true;
            this.rdoAnnually.Text = "Annually";
            this.rdoAnnually.UseVisualStyleBackColor = true;
            // 
            // rdoBiWeekly
            // 
            this.rdoBiWeekly.AutoSize = true;
            this.rdoBiWeekly.Location = new System.Drawing.Point(143, 44);
            this.rdoBiWeekly.Name = "rdoBiWeekly";
            this.rdoBiWeekly.Size = new System.Drawing.Size(140, 29);
            this.rdoBiWeekly.TabIndex = 2;
            this.rdoBiWeekly.TabStop = true;
            this.rdoBiWeekly.Text = "Bi-Weekly";
            this.rdoBiWeekly.UseVisualStyleBackColor = true;
            // 
            // rdoHourly
            // 
            this.rdoHourly.AutoSize = true;
            this.rdoHourly.Location = new System.Drawing.Point(17, 44);
            this.rdoHourly.Name = "rdoHourly";
            this.rdoHourly.Size = new System.Drawing.Size(105, 29);
            this.rdoHourly.TabIndex = 1;
            this.rdoHourly.TabStop = true;
            this.rdoHourly.Text = "Hourly";
            this.rdoHourly.UseVisualStyleBackColor = true;
            // 
            // lstCatagoriesDisplay
            // 
            this.lstCatagoriesDisplay.FormattingEnabled = true;
            this.lstCatagoriesDisplay.ItemHeight = 25;
            this.lstCatagoriesDisplay.Location = new System.Drawing.Point(27, 219);
            this.lstCatagoriesDisplay.Name = "lstCatagoriesDisplay";
            this.lstCatagoriesDisplay.Size = new System.Drawing.Size(499, 354);
            this.lstCatagoriesDisplay.TabIndex = 1;
            // 
            // lblListBox
            // 
            this.lblListBox.AutoSize = true;
            this.lblListBox.Location = new System.Drawing.Point(22, 183);
            this.lblListBox.Name = "lblListBox";
            this.lblListBox.Size = new System.Drawing.Size(116, 25);
            this.lblListBox.TabIndex = 2;
            this.lblListBox.Text = "Catagories";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(547, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(547, 305);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(186, 46);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(516, 99);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(215, 31);
            this.txtIncome.TabIndex = 6;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(511, 55);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(160, 25);
            this.lblIncome.TabIndex = 7;
            this.lblIncome.Text = "Income Amount";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(547, 378);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(186, 46);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmPersonalSpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 615);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblListBox);
            this.Controls.Add(this.lstCatagoriesDisplay);
            this.Controls.Add(this.grpIncomeFrequency);
            this.Name = "frmPersonalSpending";
            this.Text = "Personal Spending App";
            this.grpIncomeFrequency.ResumeLayout(false);
            this.grpIncomeFrequency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIncomeFrequency;
        private System.Windows.Forms.RadioButton rdoAnnually;
        private System.Windows.Forms.RadioButton rdoBiWeekly;
        private System.Windows.Forms.RadioButton rdoHourly;
        private System.Windows.Forms.ListBox lstCatagoriesDisplay;
        private System.Windows.Forms.Label lblListBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Button btnCalculate;
    }
}

