namespace Nationals_1126_DiceRoll
{
    partial class frmDiceRoll
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
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            btnRoll = new Button();
            lblLastRoll = new Label();
            label1 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(12, 62);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(225, 43);
            txtQuantity.TabIndex = 0;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 22);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(177, 37);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Side Quantity";
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(277, 62);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(169, 43);
            btnRoll.TabIndex = 2;
            btnRoll.Text = "&Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblLastRoll
            // 
            lblLastRoll.AutoSize = true;
            lblLastRoll.Location = new Point(467, 68);
            lblLastRoll.Name = "lblLastRoll";
            lblLastRoll.Size = new Size(129, 37);
            lblLastRoll.TabIndex = 3;
            lblLastRoll.Text = "Last Roll: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 4;
            label1.Text = "Hasbro, Inc";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(277, 114);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(169, 43);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmDiceRoll
            // 
            AcceptButton = btnRoll;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(748, 181);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(lblLastRoll);
            Controls.Add(btnRoll);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Name = "frmDiceRoll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasbro Dice Roll";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuantity;
        private Label lblQuantity;
        private Button btnRoll;
        private Label lblLastRoll;
        private Label label1;
        private Button btnExit;
    }
}
