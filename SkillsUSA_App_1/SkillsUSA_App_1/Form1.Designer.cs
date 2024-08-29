namespace SkillsUSA_App_1
{
    partial class Form1
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
            this.PrincipleLabel = new System.Windows.Forms.Label();
            this.InterestLabel = new System.Windows.Forms.Label();
            this.TermLabel = new System.Windows.Forms.Label();
            this.CompoundLabel = new System.Windows.Forms.Label();
            this.RepaymentLabel = new System.Windows.Forms.Label();
            this.PrincipleTextBox = new System.Windows.Forms.TextBox();
            this.InterestRateTextBox = new System.Windows.Forms.TextBox();
            this.TermTextBox = new System.Windows.Forms.TextBox();
            this.CompoundCombo = new System.Windows.Forms.ComboBox();
            this.RepaymentCombo = new System.Windows.Forms.ComboBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OutputHeader = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AccruedLabel = new System.Windows.Forms.Label();
            this.RepayLabel = new System.Windows.Forms.Label();
            this.PPRLabel = new System.Windows.Forms.Label();
            this.IPRLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrincipleLabel
            // 
            this.PrincipleLabel.AutoSize = true;
            this.PrincipleLabel.Location = new System.Drawing.Point(73, 32);
            this.PrincipleLabel.Name = "PrincipleLabel";
            this.PrincipleLabel.Size = new System.Drawing.Size(159, 25);
            this.PrincipleLabel.TabIndex = 0;
            this.PrincipleLabel.Text = "Principle (USD)";
            this.PrincipleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InterestLabel
            // 
            this.InterestLabel.AutoSize = true;
            this.InterestLabel.Location = new System.Drawing.Point(18, 63);
            this.InterestLabel.Name = "InterestLabel";
            this.InterestLabel.Size = new System.Drawing.Size(219, 25);
            this.InterestLabel.TabIndex = 1;
            this.InterestLabel.Text = "Intrest Rate (Decimal)";
            this.InterestLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Location = new System.Drawing.Point(94, 100);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(138, 25);
            this.TermLabel.TabIndex = 2;
            this.TermLabel.Text = "Term (Years)";
            this.TermLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CompoundLabel
            // 
            this.CompoundLabel.AutoSize = true;
            this.CompoundLabel.Location = new System.Drawing.Point(116, 137);
            this.CompoundLabel.Name = "CompoundLabel";
            this.CompoundLabel.Size = new System.Drawing.Size(116, 25);
            this.CompoundLabel.TabIndex = 3;
            this.CompoundLabel.Text = "Compound";
            this.CompoundLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RepaymentLabel
            // 
            this.RepaymentLabel.AutoSize = true;
            this.RepaymentLabel.Location = new System.Drawing.Point(111, 176);
            this.RepaymentLabel.Name = "RepaymentLabel";
            this.RepaymentLabel.Size = new System.Drawing.Size(121, 25);
            this.RepaymentLabel.TabIndex = 4;
            this.RepaymentLabel.Text = "Repayment";
            this.RepaymentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PrincipleTextBox
            // 
            this.PrincipleTextBox.Location = new System.Drawing.Point(269, 26);
            this.PrincipleTextBox.Name = "PrincipleTextBox";
            this.PrincipleTextBox.Size = new System.Drawing.Size(120, 31);
            this.PrincipleTextBox.TabIndex = 5;
            // 
            // InterestRateTextBox
            // 
            this.InterestRateTextBox.Location = new System.Drawing.Point(268, 63);
            this.InterestRateTextBox.Name = "InterestRateTextBox";
            this.InterestRateTextBox.Size = new System.Drawing.Size(121, 31);
            this.InterestRateTextBox.TabIndex = 6;
            // 
            // TermTextBox
            // 
            this.TermTextBox.Location = new System.Drawing.Point(268, 100);
            this.TermTextBox.Name = "TermTextBox";
            this.TermTextBox.Size = new System.Drawing.Size(121, 31);
            this.TermTextBox.TabIndex = 7;
            // 
            // CompoundCombo
            // 
            this.CompoundCombo.FormattingEnabled = true;
            this.CompoundCombo.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Quarterly",
            "Annually"});
            this.CompoundCombo.Location = new System.Drawing.Point(268, 134);
            this.CompoundCombo.Name = "CompoundCombo";
            this.CompoundCombo.Size = new System.Drawing.Size(121, 33);
            this.CompoundCombo.TabIndex = 8;
            // 
            // RepaymentCombo
            // 
            this.RepaymentCombo.FormattingEnabled = true;
            this.RepaymentCombo.Items.AddRange(new object[] {
            "Weekly",
            "Bi-Weekly",
            "Monthly",
            "Annually"});
            this.RepaymentCombo.Location = new System.Drawing.Point(268, 173);
            this.RepaymentCombo.Name = "RepaymentCombo";
            this.RepaymentCombo.Size = new System.Drawing.Size(121, 33);
            this.RepaymentCombo.TabIndex = 9;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(12, 229);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(122, 42);
            this.CalcButton.TabIndex = 10;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(141, 229);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(122, 42);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OutputHeader
            // 
            this.OutputHeader.AutoSize = true;
            this.OutputHeader.Location = new System.Drawing.Point(674, 14);
            this.OutputHeader.Name = "OutputHeader";
            this.OutputHeader.Size = new System.Drawing.Size(87, 25);
            this.OutputHeader.TabIndex = 14;
            this.OutputHeader.Text = "Outputs";
            this.OutputHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(510, 51);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(145, 25);
            this.TotalLabel.TabIndex = 15;
            this.TotalLabel.Text = "Total Amount:";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AccruedLabel
            // 
            this.AccruedLabel.AutoSize = true;
            this.AccruedLabel.Location = new System.Drawing.Point(481, 88);
            this.AccruedLabel.Name = "AccruedLabel";
            this.AccruedLabel.Size = new System.Drawing.Size(174, 25);
            this.AccruedLabel.TabIndex = 16;
            this.AccruedLabel.Text = "Interest Accrued:";
            this.AccruedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RepayLabel
            // 
            this.RepayLabel.AutoSize = true;
            this.RepayLabel.Location = new System.Drawing.Point(449, 124);
            this.RepayLabel.Name = "RepayLabel";
            this.RepayLabel.Size = new System.Drawing.Size(206, 25);
            this.RepayLabel.TabIndex = 17;
            this.RepayLabel.Text = "Repayment Amount:";
            this.RepayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PPRLabel
            // 
            this.PPRLabel.AutoSize = true;
            this.PPRLabel.Location = new System.Drawing.Point(449, 163);
            this.PPRLabel.Name = "PPRLabel";
            this.PPRLabel.Size = new System.Drawing.Size(208, 25);
            this.PPRLabel.TabIndex = 18;
            this.PPRLabel.Text = "Principle Per Repay:";
            this.PPRLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IPRLabel
            // 
            this.IPRLabel.AutoSize = true;
            this.IPRLabel.Location = new System.Drawing.Point(461, 200);
            this.IPRLabel.Name = "IPRLabel";
            this.IPRLabel.Size = new System.Drawing.Size(196, 25);
            this.IPRLabel.TabIndex = 19;
            this.IPRLabel.Text = "Interest Per Repay:";
            this.IPRLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(845, 285);
            this.Controls.Add(this.IPRLabel);
            this.Controls.Add(this.PPRLabel);
            this.Controls.Add(this.RepayLabel);
            this.Controls.Add(this.AccruedLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.OutputHeader);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.RepaymentCombo);
            this.Controls.Add(this.CompoundCombo);
            this.Controls.Add(this.TermTextBox);
            this.Controls.Add(this.InterestRateTextBox);
            this.Controls.Add(this.PrincipleTextBox);
            this.Controls.Add(this.RepaymentLabel);
            this.Controls.Add(this.CompoundLabel);
            this.Controls.Add(this.TermLabel);
            this.Controls.Add(this.InterestLabel);
            this.Controls.Add(this.PrincipleLabel);
            this.Name = "Form1";
            this.Text = "Compound Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrincipleLabel;
        private System.Windows.Forms.Label InterestLabel;
        private System.Windows.Forms.Label TermLabel;
        private System.Windows.Forms.Label CompoundLabel;
        private System.Windows.Forms.Label RepaymentLabel;
        private System.Windows.Forms.TextBox PrincipleTextBox;
        private System.Windows.Forms.TextBox InterestRateTextBox;
        private System.Windows.Forms.TextBox TermTextBox;
        private System.Windows.Forms.ComboBox CompoundCombo;
        private System.Windows.Forms.ComboBox RepaymentCombo;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label OutputHeader;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label AccruedLabel;
        private System.Windows.Forms.Label RepayLabel;
        private System.Windows.Forms.Label PPRLabel;
        private System.Windows.Forms.Label IPRLabel;
    }
}

