namespace ATM_Banking_Machine
{
    partial class FastCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastCash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fastCash10 = new ePOSOne.btnProduct.Button_WOC();
            this.fastCash20 = new ePOSOne.btnProduct.Button_WOC();
            this.fastCash50 = new ePOSOne.btnProduct.Button_WOC();
            this.fastCash100 = new ePOSOne.btnProduct.Button_WOC();
            this.fastCash200 = new ePOSOne.btnProduct.Button_WOC();
            this.fastCash500 = new ePOSOne.btnProduct.Button_WOC();
            this.availableBalanceLbl = new System.Windows.Forms.Label();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(357, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 39);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fast Cash";
            // 
            // fastCash10
            // 
            this.fastCash10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fastCash10.BorderColor = System.Drawing.Color.Black;
            this.fastCash10.ButtonColor = System.Drawing.Color.DarkCyan;
            this.fastCash10.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fastCash10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastCash10.Location = new System.Drawing.Point(78, 165);
            this.fastCash10.Name = "fastCash10";
            this.fastCash10.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fastCash10.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.fastCash10.OnHoverTextColor = System.Drawing.Color.Black;
            this.fastCash10.Size = new System.Drawing.Size(168, 58);
            this.fastCash10.TabIndex = 38;
            this.fastCash10.Text = "10€";
            this.fastCash10.TextColor = System.Drawing.Color.Black;
            this.fastCash10.UseVisualStyleBackColor = false;
            this.fastCash10.Click += new System.EventHandler(this.fastCash10_Click);
            // 
            // fastCash20
            // 
            this.fastCash20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fastCash20.BorderColor = System.Drawing.Color.Black;
            this.fastCash20.ButtonColor = System.Drawing.Color.DarkCyan;
            this.fastCash20.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fastCash20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastCash20.Location = new System.Drawing.Point(78, 250);
            this.fastCash20.Name = "fastCash20";
            this.fastCash20.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fastCash20.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.fastCash20.OnHoverTextColor = System.Drawing.Color.Black;
            this.fastCash20.Size = new System.Drawing.Size(168, 58);
            this.fastCash20.TabIndex = 39;
            this.fastCash20.Text = "20€";
            this.fastCash20.TextColor = System.Drawing.Color.Black;
            this.fastCash20.UseVisualStyleBackColor = false;
            this.fastCash20.Click += new System.EventHandler(this.fastCash20_Click);
            // 
            // fastCash50
            // 
            this.fastCash50.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fastCash50.BorderColor = System.Drawing.Color.Black;
            this.fastCash50.ButtonColor = System.Drawing.Color.DarkCyan;
            this.fastCash50.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fastCash50.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastCash50.Location = new System.Drawing.Point(78, 331);
            this.fastCash50.Name = "fastCash50";
            this.fastCash50.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fastCash50.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.fastCash50.OnHoverTextColor = System.Drawing.Color.Black;
            this.fastCash50.Size = new System.Drawing.Size(168, 58);
            this.fastCash50.TabIndex = 40;
            this.fastCash50.Text = "50€";
            this.fastCash50.TextColor = System.Drawing.Color.Black;
            this.fastCash50.UseVisualStyleBackColor = false;
            this.fastCash50.Click += new System.EventHandler(this.fastCash50_Click);
            // 
            // fastCash100
            // 
            this.fastCash100.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fastCash100.BorderColor = System.Drawing.Color.Black;
            this.fastCash100.ButtonColor = System.Drawing.Color.DarkCyan;
            this.fastCash100.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fastCash100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastCash100.Location = new System.Drawing.Point(607, 165);
            this.fastCash100.Name = "fastCash100";
            this.fastCash100.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fastCash100.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.fastCash100.OnHoverTextColor = System.Drawing.Color.Black;
            this.fastCash100.Size = new System.Drawing.Size(168, 58);
            this.fastCash100.TabIndex = 41;
            this.fastCash100.Text = "100€";
            this.fastCash100.TextColor = System.Drawing.Color.Black;
            this.fastCash100.UseVisualStyleBackColor = false;
            this.fastCash100.Click += new System.EventHandler(this.fastCash100_Click);
            // 
            // fastCash200
            // 
            this.fastCash200.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fastCash200.BorderColor = System.Drawing.Color.Black;
            this.fastCash200.ButtonColor = System.Drawing.Color.DarkCyan;
            this.fastCash200.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fastCash200.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastCash200.Location = new System.Drawing.Point(607, 250);
            this.fastCash200.Name = "fastCash200";
            this.fastCash200.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fastCash200.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.fastCash200.OnHoverTextColor = System.Drawing.Color.Black;
            this.fastCash200.Size = new System.Drawing.Size(168, 58);
            this.fastCash200.TabIndex = 42;
            this.fastCash200.Text = "200€";
            this.fastCash200.TextColor = System.Drawing.Color.Black;
            this.fastCash200.UseVisualStyleBackColor = false;
            this.fastCash200.Click += new System.EventHandler(this.fastCash200_Click);
            // 
            // fastCash500
            // 
            this.fastCash500.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fastCash500.BorderColor = System.Drawing.Color.Black;
            this.fastCash500.ButtonColor = System.Drawing.Color.DarkCyan;
            this.fastCash500.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fastCash500.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastCash500.Location = new System.Drawing.Point(607, 331);
            this.fastCash500.Name = "fastCash500";
            this.fastCash500.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fastCash500.OnHoverButtonColor = System.Drawing.Color.DarkSlateGray;
            this.fastCash500.OnHoverTextColor = System.Drawing.Color.Black;
            this.fastCash500.Size = new System.Drawing.Size(168, 58);
            this.fastCash500.TabIndex = 43;
            this.fastCash500.Text = "500€";
            this.fastCash500.TextColor = System.Drawing.Color.Black;
            this.fastCash500.UseVisualStyleBackColor = false;
            this.fastCash500.Click += new System.EventHandler(this.fastCash500_Click);
            // 
            // availableBalanceLbl
            // 
            this.availableBalanceLbl.AutoSize = true;
            this.availableBalanceLbl.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.availableBalanceLbl.Location = new System.Drawing.Point(309, 232);
            this.availableBalanceLbl.Name = "availableBalanceLbl";
            this.availableBalanceLbl.Size = new System.Drawing.Size(226, 39);
            this.availableBalanceLbl.TabIndex = 44;
            this.availableBalanceLbl.Text = "Available balance";
            // 
            // backPB
            // 
            this.backPB.Image = ((System.Drawing.Image)(resources.GetObject("backPB.Image")));
            this.backPB.Location = new System.Drawing.Point(0, 0);
            this.backPB.Name = "backPB";
            this.backPB.Size = new System.Drawing.Size(64, 60);
            this.backPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPB.TabIndex = 41;
            this.backPB.TabStop = false;
            this.backPB.Click += new System.EventHandler(this.backPB_Click);
            // 
            // FastCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.availableBalanceLbl);
            this.Controls.Add(this.fastCash500);
            this.Controls.Add(this.fastCash200);
            this.Controls.Add(this.fastCash100);
            this.Controls.Add(this.fastCash50);
            this.Controls.Add(this.fastCash20);
            this.Controls.Add(this.fastCash10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastCash";
            this.Load += new System.EventHandler(this.FastCash_Load);
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
        private Label label4;
        private ePOSOne.btnProduct.Button_WOC fastCash10;
        private ePOSOne.btnProduct.Button_WOC fastCash20;
        private ePOSOne.btnProduct.Button_WOC fastCash50;
        private ePOSOne.btnProduct.Button_WOC fastCash100;
        private ePOSOne.btnProduct.Button_WOC fastCash200;
        private ePOSOne.btnProduct.Button_WOC fastCash500;
        private Label availableBalanceLbl;
        private PictureBox backPB;
    }
}