namespace ATM_Banking_Machine
{
    partial class Withdraw
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backLbl = new System.Windows.Forms.Label();
            this.exitLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.withdrawAmountTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.withdrawBtn = new ePOSOne.btnProduct.Button_WOC();
            this.availableBalanceLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.backLbl);
            this.panel1.Controls.Add(this.exitLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 100);
            this.panel1.TabIndex = 2;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backLbl.Location = new System.Drawing.Point(0, 0);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(237, 37);
            this.backLbl.TabIndex = 19;
            this.backLbl.Text = "<BACK TO MENU";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.exitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitLbl.Location = new System.Drawing.Point(793, 0);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(41, 39);
            this.exitLbl.TabIndex = 1;
            this.exitLbl.Text = "X";
            this.exitLbl.Click += new System.EventHandler(this.exitLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(353, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 39);
            this.label4.TabIndex = 27;
            this.label4.Text = "Withdraw";
            // 
            // withdrawAmountTb
            // 
            this.withdrawAmountTb.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdrawAmountTb.Location = new System.Drawing.Point(323, 202);
            this.withdrawAmountTb.Name = "withdrawAmountTb";
            this.withdrawAmountTb.Size = new System.Drawing.Size(200, 41);
            this.withdrawAmountTb.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 39);
            this.label3.TabIndex = 29;
            this.label3.Text = "Amount";
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.withdrawBtn.BorderColor = System.Drawing.Color.Black;
            this.withdrawBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.withdrawBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdrawBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.withdrawBtn.Location = new System.Drawing.Point(339, 249);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.withdrawBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.withdrawBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.withdrawBtn.Size = new System.Drawing.Size(168, 58);
            this.withdrawBtn.TabIndex = 31;
            this.withdrawBtn.Text = "WITHDRAW";
            this.withdrawBtn.TextColor = System.Drawing.Color.Black;
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // availableBalanceLbl
            // 
            this.availableBalanceLbl.AutoSize = true;
            this.availableBalanceLbl.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.availableBalanceLbl.Location = new System.Drawing.Point(323, 160);
            this.availableBalanceLbl.Name = "availableBalanceLbl";
            this.availableBalanceLbl.Size = new System.Drawing.Size(226, 39);
            this.availableBalanceLbl.TabIndex = 32;
            this.availableBalanceLbl.Text = "Available balance";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.availableBalanceLbl);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.withdrawAmountTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label backLbl;
        private Label exitLbl;
        private Label label1;
        private Label label4;
        private TextBox withdrawAmountTb;
        private Label label3;
        private ePOSOne.btnProduct.Button_WOC withdrawBtn;
        private Label availableBalanceLbl;
    }
}