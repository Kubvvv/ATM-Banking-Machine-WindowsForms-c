namespace ATM_Banking_Machine
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accNumberLbl = new System.Windows.Forms.Label();
            this.balanceEuroLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backPB = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.backPB);
            this.panel1.Controls.Add(this.exitLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 100);
            this.panel1.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(144, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 39);
            this.label3.TabIndex = 28;
            this.label3.Text = "ACCOUNT NUMBER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(191, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "YOUR BALANCE:";
            // 
            // accNumberLbl
            // 
            this.accNumberLbl.AutoSize = true;
            this.accNumberLbl.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accNumberLbl.Location = new System.Drawing.Point(443, 162);
            this.accNumberLbl.Name = "accNumberLbl";
            this.accNumberLbl.Size = new System.Drawing.Size(112, 39);
            this.accNumberLbl.TabIndex = 30;
            this.accNumberLbl.Text = "accNum";
            // 
            // balanceEuroLbl
            // 
            this.balanceEuroLbl.AutoSize = true;
            this.balanceEuroLbl.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balanceEuroLbl.Location = new System.Drawing.Point(443, 232);
            this.balanceEuroLbl.Name = "balanceEuroLbl";
            this.balanceEuroLbl.Size = new System.Drawing.Size(193, 39);
            this.balanceEuroLbl.TabIndex = 31;
            this.balanceEuroLbl.Text = "BalanceInEuro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(277, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 39);
            this.label4.TabIndex = 32;
            this.label4.Text = "Account Information";
            // 
            // backPB
            // 
            this.backPB.Image = ((System.Drawing.Image)(resources.GetObject("backPB.Image")));
            this.backPB.Location = new System.Drawing.Point(0, 0);
            this.backPB.Name = "backPB";
            this.backPB.Size = new System.Drawing.Size(64, 60);
            this.backPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPB.TabIndex = 39;
            this.backPB.TabStop = false;
            this.backPB.Click += new System.EventHandler(this.backPB_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balanceEuroLbl);
            this.Controls.Add(this.accNumberLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label exitLbl;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label accNumberLbl;
        private Label balanceEuroLbl;
        private Label label4;
        private PictureBox backPB;
    }
}