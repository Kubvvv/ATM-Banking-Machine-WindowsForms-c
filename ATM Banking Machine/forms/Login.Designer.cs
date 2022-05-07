namespace ATM_Banking_Machine
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginAccNumTb = new System.Windows.Forms.TextBox();
            this.loginPinTb = new System.Windows.Forms.TextBox();
            this.loginBtn = new ePOSOne.btnProduct.Button_WOC();
            this.label4 = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(850, 100);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM_Banking_Machine.Properties.Resources.withdraw_logo;
            this.pictureBox1.Location = new System.Drawing.Point(72, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(326, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(408, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "PIN CODE";
            // 
            // loginAccNumTb
            // 
            this.loginAccNumTb.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginAccNumTb.Location = new System.Drawing.Point(567, 191);
            this.loginAccNumTb.Name = "loginAccNumTb";
            this.loginAccNumTb.Size = new System.Drawing.Size(200, 41);
            this.loginAccNumTb.TabIndex = 22;
            // 
            // loginPinTb
            // 
            this.loginPinTb.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginPinTb.Location = new System.Drawing.Point(567, 257);
            this.loginPinTb.Name = "loginPinTb";
            this.loginPinTb.PasswordChar = '*';
            this.loginPinTb.Size = new System.Drawing.Size(200, 41);
            this.loginPinTb.TabIndex = 23;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.BorderColor = System.Drawing.Color.Black;
            this.loginBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.loginBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginBtn.Location = new System.Drawing.Point(601, 313);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.loginBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.loginBtn.Size = new System.Drawing.Size(133, 54);
            this.loginBtn.TabIndex = 24;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.TextColor = System.Drawing.Color.Black;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(385, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 39);
            this.label4.TabIndex = 25;
            this.label4.Text = "Login";
            // 
            // signupBtn
            // 
            this.signupBtn.AutoSize = true;
            this.signupBtn.Font = new System.Drawing.Font("Sitka Heading", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.signupBtn.Location = new System.Drawing.Point(611, 413);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(112, 39);
            this.signupBtn.TabIndex = 26;
            this.signupBtn.Text = "SIGNUP";
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(98, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(497, 39);
            this.label6.TabIndex = 27;
            this.label6.Text = "You dont have an account? Click here ->";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginPinTb);
            this.Controls.Add(this.loginAccNumTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label exitLbl;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private TextBox loginAccNumTb;
        private TextBox loginPinTb;
        private ePOSOne.btnProduct.Button_WOC loginBtn;
        private Label label4;
        private Label signupBtn;
        private Label label6;
    }
}