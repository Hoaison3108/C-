namespace Bai8_Winform
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
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSLI = new System.Windows.Forms.Button();
            this.btnGan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSLIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3"});
            this.lstDanhSach.Location = new System.Drawing.Point(40, 29);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDanhSach.Size = new System.Drawing.Size(214, 160);
            this.lstDanhSach.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(181, 196);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(105, 36);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(40, 251);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(105, 36);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(181, 251);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 36);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSLI
            // 
            this.btnSLI.Location = new System.Drawing.Point(40, 307);
            this.btnSLI.Name = "btnSLI";
            this.btnSLI.Size = new System.Drawing.Size(105, 36);
            this.btnSLI.TabIndex = 5;
            this.btnSLI.Text = "SelectionIndices";
            this.btnSLI.UseVisualStyleBackColor = true;
            this.btnSLI.Click += new System.EventHandler(this.btnSLI_Click);
            // 
            // btnGan
            // 
            this.btnGan.Location = new System.Drawing.Point(0, 0);
            this.btnGan.Name = "btnGan";
            this.btnGan.Size = new System.Drawing.Size(75, 23);
            this.btnGan.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(181, 307);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Gan";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSLIndex
            // 
            this.btnSLIndex.Location = new System.Drawing.Point(40, 362);
            this.btnSLIndex.Name = "btnSLIndex";
            this.btnSLIndex.Size = new System.Drawing.Size(105, 36);
            this.btnSLIndex.TabIndex = 8;
            this.btnSLIndex.Text = "SelectedIndex";
            this.btnSLIndex.UseVisualStyleBackColor = true;
            this.btnSLIndex.Click += new System.EventHandler(this.btnSLIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 628);
            this.Controls.Add(this.btnSLIndex);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnGan);
            this.Controls.Add(this.btnSLI);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstDanhSach);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSLI;
        private System.Windows.Forms.Button btnGan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSLIndex;
    }
}

