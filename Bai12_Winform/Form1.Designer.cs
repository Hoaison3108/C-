namespace Bai12_Winform
{
    partial class frmForm1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.sắpXếpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuOpen
            // 
            this.mnuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenForm1,
            this.mnuOpenForm2,
            this.mnuOpenForm3,
            this.mnuOpenForm4});
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(48, 20);
            this.mnuOpen.Text = "Open";
            // 
            // mnuOpenForm1
            // 
            this.mnuOpenForm1.Name = "mnuOpenForm1";
            this.mnuOpenForm1.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm1.Text = "Form 1";
            this.mnuOpenForm1.Click += new System.EventHandler(this.mnuOpenForm1_Click);
            // 
            // mnuOpenForm2
            // 
            this.mnuOpenForm2.Name = "mnuOpenForm2";
            this.mnuOpenForm2.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm2.Text = "Form 2";
            this.mnuOpenForm2.Click += new System.EventHandler(this.mnuOpenForm2_Click);
            // 
            // mnuOpenForm3
            // 
            this.mnuOpenForm3.Name = "mnuOpenForm3";
            this.mnuOpenForm3.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm3.Text = "Form 3";
            this.mnuOpenForm3.Click += new System.EventHandler(this.mnuOpenForm3_Click);
            // 
            // mnuOpenForm4
            // 
            this.mnuOpenForm4.Name = "mnuOpenForm4";
            this.mnuOpenForm4.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm4.Text = "Form 4";
            this.mnuOpenForm4.Click += new System.EventHandler(this.mnuOpenForm4_Click);
            // 
            // sắpXếpToolStripMenuItem
            // 
            this.sắpXếpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểu1ToolStripMenuItem,
            this.kiểu2ToolStripMenuItem,
            this.kiểu3ToolStripMenuItem,
            this.kiểuToolStripMenuItem});
            this.sắpXếpToolStripMenuItem.Name = "sắpXếpToolStripMenuItem";
            this.sắpXếpToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sắpXếpToolStripMenuItem.Text = "Sắp xếp";
            // 
            // kiểu1ToolStripMenuItem
            // 
            this.kiểu1ToolStripMenuItem.Name = "kiểu1ToolStripMenuItem";
            this.kiểu1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kiểu1ToolStripMenuItem.Text = "Kiểu 1";
            this.kiểu1ToolStripMenuItem.Click += new System.EventHandler(this.kiểu1ToolStripMenuItem_Click);
            // 
            // kiểu2ToolStripMenuItem
            // 
            this.kiểu2ToolStripMenuItem.Name = "kiểu2ToolStripMenuItem";
            this.kiểu2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kiểu2ToolStripMenuItem.Text = "Kiểu 2";
            this.kiểu2ToolStripMenuItem.Click += new System.EventHandler(this.kiểu2ToolStripMenuItem_Click);
            // 
            // kiểu3ToolStripMenuItem
            // 
            this.kiểu3ToolStripMenuItem.Name = "kiểu3ToolStripMenuItem";
            this.kiểu3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kiểu3ToolStripMenuItem.Text = "Kiểu 3";
            this.kiểu3ToolStripMenuItem.Click += new System.EventHandler(this.kiểu3ToolStripMenuItem_Click);
            // 
            // kiểuToolStripMenuItem
            // 
            this.kiểuToolStripMenuItem.Name = "kiểuToolStripMenuItem";
            this.kiểuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kiểuToolStripMenuItem.Text = "Kiểu 4";
            this.kiểuToolStripMenuItem.Click += new System.EventHandler(this.kiểuToolStripMenuItem_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(29, 171);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmForm1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmForm1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm2;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm3;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm4;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểu3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểuToolStripMenuItem;
        private System.Windows.Forms.Button btnLogin;
    }
}

