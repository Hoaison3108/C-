namespace Bai5_Winform
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
            this.grpSoThich = new System.Windows.Forms.GroupBox();
            this.chkXemPhim = new System.Windows.Forms.CheckBox();
            this.chkDuLich = new System.Windows.Forms.CheckBox();
            this.chkTheThao = new System.Windows.Forms.CheckBox();
            this.chkNgheNhac = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.grpSoThich.SuspendLayout();
            this.grpGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSoThich
            // 
            this.grpSoThich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpSoThich.Controls.Add(this.chkNgheNhac);
            this.grpSoThich.Controls.Add(this.chkTheThao);
            this.grpSoThich.Controls.Add(this.chkDuLich);
            this.grpSoThich.Controls.Add(this.chkXemPhim);
            this.grpSoThich.Location = new System.Drawing.Point(54, 58);
            this.grpSoThich.Name = "grpSoThich";
            this.grpSoThich.Size = new System.Drawing.Size(157, 121);
            this.grpSoThich.TabIndex = 0;
            this.grpSoThich.TabStop = false;
            this.grpSoThich.Text = "Sở Thích";
            // 
            // chkXemPhim
            // 
            this.chkXemPhim.AutoSize = true;
            this.chkXemPhim.Location = new System.Drawing.Point(30, 35);
            this.chkXemPhim.Name = "chkXemPhim";
            this.chkXemPhim.Size = new System.Drawing.Size(73, 17);
            this.chkXemPhim.TabIndex = 0;
            this.chkXemPhim.Text = "Xem Phim";
            this.chkXemPhim.UseVisualStyleBackColor = true;
            // 
            // chkDuLich
            // 
            this.chkDuLich.AutoSize = true;
            this.chkDuLich.Location = new System.Drawing.Point(30, 52);
            this.chkDuLich.Name = "chkDuLich";
            this.chkDuLich.Size = new System.Drawing.Size(63, 17);
            this.chkDuLich.TabIndex = 1;
            this.chkDuLich.Text = "Du Lịch";
            this.chkDuLich.UseVisualStyleBackColor = true;
            // 
            // chkTheThao
            // 
            this.chkTheThao.AutoSize = true;
            this.chkTheThao.Location = new System.Drawing.Point(30, 69);
            this.chkTheThao.Name = "chkTheThao";
            this.chkTheThao.Size = new System.Drawing.Size(73, 17);
            this.chkTheThao.TabIndex = 2;
            this.chkTheThao.Text = "Thể Thao";
            this.chkTheThao.UseVisualStyleBackColor = true;
            // 
            // chkNgheNhac
            // 
            this.chkNgheNhac.AutoSize = true;
            this.chkNgheNhac.Location = new System.Drawing.Point(30, 86);
            this.chkNgheNhac.Name = "chkNgheNhac";
            this.chkNgheNhac.Size = new System.Drawing.Size(81, 17);
            this.chkNgheNhac.TabIndex = 3;
            this.chkNgheNhac.Text = "Nghe Nhạc";
            this.chkNgheNhac.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(54, 207);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(6, 34);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // grpGioiTinh
            // 
            this.grpGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grpGioiTinh.Controls.Add(this.radNu);
            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Location = new System.Drawing.Point(217, 58);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(157, 121);
            this.grpGioiTinh.TabIndex = 3;
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới Tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(7, 58);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 3;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 309);
            this.Controls.Add(this.grpGioiTinh);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.grpSoThich);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpSoThich.ResumeLayout(false);
            this.grpSoThich.PerformLayout();
            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSoThich;
        private System.Windows.Forms.CheckBox chkXemPhim;
        private System.Windows.Forms.CheckBox chkNgheNhac;
        private System.Windows.Forms.CheckBox chkTheThao;
        private System.Windows.Forms.CheckBox chkDuLich;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton radNu;
    }
}

