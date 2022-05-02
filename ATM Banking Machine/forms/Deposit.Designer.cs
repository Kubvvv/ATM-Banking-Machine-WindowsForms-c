namespace ATM_Banking_Machine
{
    partial class Deposit
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
            this.depositAmountTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depositBtn = new ePOSOne.btnProduct.Button_WOC();
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
            this.panel1.Size = new System.Drawing.Size(850, 100);
            this.panel1.TabIndex = 1;
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
            this.label4.Location = new System.Drawing.Point(363, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 39);
            this.label4.TabIndex = 26;
            this.label4.Text = "Deposit";
            // 
            // depositAmountTb
            // 
            this.depositAmountTb.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositAmountTb.Location = new System.Drawing.Point(414, 156);
            this.depositAmountTb.Name = "depositAmountTb";
            this.depositAmountTb.Size = new System.Drawing.Size(200, 41);
            this.depositAmountTb.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(272, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 39);
            this.label3.TabIndex = 27;
            this.label3.Text = "Amount";
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depositBtn.BorderColor = System.Drawing.Color.Black;
            this.depositBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.depositBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.depositBtn.Location = new System.Drawing.Point(432, 213);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.depositBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.depositBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.depositBtn.Size = new System.Drawing.Size(168, 58);
            this.depositBtn.TabIndex = 29;
            this.depositBtn.Text = "DEPOSIT";
            this.depositBtn.TextColor = System.Drawing.Color.Black;
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 300);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.depositAmountTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
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
        private TextBox depositAmountTb;
        private Label label3;
        private ePOSOne.btnProduct.Button_WOC depositBtn;
    }
}