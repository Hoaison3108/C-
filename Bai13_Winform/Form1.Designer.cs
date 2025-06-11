namespace Bai13_Winform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnImage = new System.Windows.Forms.Button();
            this.lbImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            // 
            // btnImage
            // 
            this.btnImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImage.ImageIndex = 0;
            this.btnImage.ImageList = this.imageList1;
            this.btnImage.Location = new System.Drawing.Point(30, 35);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(108, 49);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lbImage
            // 
            this.lbImage.ImageList = this.imageList1;
            this.lbImage.Location = new System.Drawing.Point(27, 113);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(360, 272);
            this.lbImage.TabIndex = 1;
            this.lbImage.Text = "I";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 480);
            this.Controls.Add(this.lbImage);
            this.Controls.Add(this.btnImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lbImage;
    }
}

