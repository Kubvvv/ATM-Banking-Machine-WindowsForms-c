namespace ATM_Banking_Machine
{
    partial class Home
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
            this.exitLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accNumLbl = new System.Windows.Forms.Label();
            this.depositBtn = new ePOSOne.btnProduct.Button_WOC();
            this.fastCashBtn = new ePOSOne.btnProduct.Button_WOC();
            this.changePinBtn = new ePOSOne.btnProduct.Button_WOC();
            this.withdrawBtn = new ePOSOne.btnProduct.Button_WOC();
            this.miniStatementBtn = new ePOSOne.btnProduct.Button_WOC();
            this.balanceBtn = new ePOSOne.btnProduct.Button_WOC();
            this.logoutLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.exitLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 100);
            this.panel1.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accNumLbl
            // 
            this.accNumLbl.AutoSize = true;
            this.accNumLbl.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accNumLbl.Location = new System.Drawing.Point(304, 103);
            this.accNumLbl.Name = "accNumLbl";
            this.accNumLbl.Size = new System.Drawing.Size(210, 39);
            this.accNumLbl.TabIndex = 26;
            this.accNumLbl.Text = "AccountNumber";
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depositBtn.BorderColor = System.Drawing.Color.Black;
            this.depositBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.depositBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.depositBtn.Location = new System.Drawing.Point(111, 146);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.depositBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.depositBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.depositBtn.Size = new System.Drawing.Size(168, 58);
            this.depositBtn.TabIndex = 27;
            this.depositBtn.Text = "DEPOSIT";
            this.depositBtn.TextColor = System.Drawing.Color.Black;
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // fastCashBtn
            // 
            this.fastCashBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fastCashBtn.BorderColor = System.Drawing.Color.Black;
            this.fastCashBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.fastCashBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fastCashBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastCashBtn.Location = new System.Drawing.Point(111, 240);
            this.fastCashBtn.Name = "fastCashBtn";
            this.fastCashBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fastCashBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.fastCashBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.fastCashBtn.Size = new System.Drawing.Size(168, 58);
            this.fastCashBtn.TabIndex = 28;
            this.fastCashBtn.Text = "FAST CASH";
            this.fastCashBtn.TextColor = System.Drawing.Color.Black;
            this.fastCashBtn.UseVisualStyleBackColor = false;
            // 
            // changePinBtn
            // 
            this.changePinBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePinBtn.BorderColor = System.Drawing.Color.Black;
            this.changePinBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.changePinBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changePinBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changePinBtn.Location = new System.Drawing.Point(111, 327);
            this.changePinBtn.Name = "changePinBtn";
            this.changePinBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.changePinBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.changePinBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.changePinBtn.Size = new System.Drawing.Size(168, 58);
            this.changePinBtn.TabIndex = 29;
            this.changePinBtn.Text = "CHANGE PIN";
            this.changePinBtn.TextColor = System.Drawing.Color.Black;
            this.changePinBtn.UseVisualStyleBackColor = false;
            this.changePinBtn.Click += new System.EventHandler(this.changePinBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.withdrawBtn.BorderColor = System.Drawing.Color.Black;
            this.withdrawBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.withdrawBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdrawBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.withdrawBtn.Location = new System.Drawing.Point(575, 146);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.withdrawBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.withdrawBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.withdrawBtn.Size = new System.Drawing.Size(168, 58);
            this.withdrawBtn.TabIndex = 30;
            this.withdrawBtn.Text = "WITHDRAW";
            this.withdrawBtn.TextColor = System.Drawing.Color.Black;
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // miniStatementBtn
            // 
            this.miniStatementBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miniStatementBtn.BorderColor = System.Drawing.Color.Black;
            this.miniStatementBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.miniStatementBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.miniStatementBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.miniStatementBtn.Location = new System.Drawing.Point(575, 240);
            this.miniStatementBtn.Name = "miniStatementBtn";
            this.miniStatementBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.miniStatementBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.miniStatementBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.miniStatementBtn.Size = new System.Drawing.Size(168, 58);
            this.miniStatementBtn.TabIndex = 31;
            this.miniStatementBtn.Text = "      MINI \r\nSTATEMENT";
            this.miniStatementBtn.TextColor = System.Drawing.Color.Black;
            this.miniStatementBtn.UseVisualStyleBackColor = false;
            // 
            // balanceBtn
            // 
            this.balanceBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balanceBtn.BorderColor = System.Drawing.Color.Black;
            this.balanceBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.balanceBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balanceBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.balanceBtn.Location = new System.Drawing.Point(575, 327);
            this.balanceBtn.Name = "balanceBtn";
            this.balanceBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.balanceBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.balanceBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.balanceBtn.Size = new System.Drawing.Size(168, 58);
            this.balanceBtn.TabIndex = 32;
            this.balanceBtn.Text = "BALANCE";
            this.balanceBtn.TextColor = System.Drawing.Color.Black;
            this.balanceBtn.UseVisualStyleBackColor = false;
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutLbl.Location = new System.Drawing.Point(367, 413);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(122, 39);
            this.logoutLbl.TabIndex = 33;
            this.logoutLbl.Text = "LOGOUT";
            this.logoutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutLbl.Click += new System.EventHandler(this.logoutLbl_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.logoutLbl);
            this.Controls.Add(this.balanceBtn);
            this.Controls.Add(this.miniStatementBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.changePinBtn);
            this.Controls.Add(this.fastCashBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.accNumLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label exitLbl;
        private Label label1;
        private Label accNumLbl;
        private ePOSOne.btnProduct.Button_WOC depositBtn;
        private ePOSOne.btnProduct.Button_WOC fastCashBtn;
        private ePOSOne.btnProduct.Button_WOC changePinBtn;
        private ePOSOne.btnProduct.Button_WOC withdrawBtn;
        private ePOSOne.btnProduct.Button_WOC miniStatementBtn;
        private ePOSOne.btnProduct.Button_WOC balanceBtn;
        private Label logoutLbl;
    }
}