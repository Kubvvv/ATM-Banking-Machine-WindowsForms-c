namespace ATM_Banking_Machine
{
    partial class ChangePin
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
            this.oldPinTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newPinTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmNewPinTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pinChangeBtn = new ePOSOne.btnProduct.Button_WOC();
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
            this.panel1.TabIndex = 3;
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
            this.label4.Location = new System.Drawing.Point(351, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 39);
            this.label4.TabIndex = 28;
            this.label4.Text = "Pin Change";
            // 
            // oldPinTb
            // 
            this.oldPinTb.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oldPinTb.Location = new System.Drawing.Point(391, 154);
            this.oldPinTb.Name = "oldPinTb";
            this.oldPinTb.Size = new System.Drawing.Size(200, 41);
            this.oldPinTb.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(249, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 39);
            this.label3.TabIndex = 31;
            this.label3.Text = "OLD PIN";
            // 
            // newPinTb
            // 
            this.newPinTb.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newPinTb.Location = new System.Drawing.Point(391, 205);
            this.newPinTb.Name = "newPinTb";
            this.newPinTb.Size = new System.Drawing.Size(200, 41);
            this.newPinTb.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(249, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 39);
            this.label2.TabIndex = 33;
            this.label2.Text = "NEW PIN";
            // 
            // confirmNewPinTb
            // 
            this.confirmNewPinTb.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmNewPinTb.Location = new System.Drawing.Point(391, 259);
            this.confirmNewPinTb.Name = "confirmNewPinTb";
            this.confirmNewPinTb.Size = new System.Drawing.Size(200, 41);
            this.confirmNewPinTb.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(125, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 39);
            this.label5.TabIndex = 35;
            this.label5.Text = "CONFIRM NEW PIN";
            // 
            // pinChangeBtn
            // 
            this.pinChangeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pinChangeBtn.BorderColor = System.Drawing.Color.Black;
            this.pinChangeBtn.ButtonColor = System.Drawing.Color.DarkCyan;
            this.pinChangeBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pinChangeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pinChangeBtn.Location = new System.Drawing.Point(410, 306);
            this.pinChangeBtn.Name = "pinChangeBtn";
            this.pinChangeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.pinChangeBtn.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.pinChangeBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.pinChangeBtn.Size = new System.Drawing.Size(168, 58);
            this.pinChangeBtn.TabIndex = 37;
            this.pinChangeBtn.Text = "CHANGE";
            this.pinChangeBtn.TextColor = System.Drawing.Color.Black;
            this.pinChangeBtn.UseVisualStyleBackColor = false;
            this.pinChangeBtn.Click += new System.EventHandler(this.pinChangeBtn_Click);
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 400);
            this.Controls.Add(this.pinChangeBtn);
            this.Controls.Add(this.confirmNewPinTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newPinTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPinTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePin";
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
        private TextBox oldPinTb;
        private Label label3;
        private TextBox newPinTb;
        private Label label2;
        private TextBox confirmNewPinTb;
        private Label label5;
        private ePOSOne.btnProduct.Button_WOC pinChangeBtn;
    }
}