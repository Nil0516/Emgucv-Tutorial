namespace MyEmgucv
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.buttonGetImagePath = new System.Windows.Forms.Button();
            this.pictureBoxDisplayImage = new System.Windows.Forms.PictureBox();
            this.button2GrayImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Location = new System.Drawing.Point(12, 12);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(651, 33);
            this.textBoxImagePath.TabIndex = 0;
            // 
            // buttonGetImagePath
            // 
            this.buttonGetImagePath.Location = new System.Drawing.Point(669, 12);
            this.buttonGetImagePath.Name = "buttonGetImagePath";
            this.buttonGetImagePath.Size = new System.Drawing.Size(155, 33);
            this.buttonGetImagePath.TabIndex = 1;
            this.buttonGetImagePath.Text = "讀取影像";
            this.buttonGetImagePath.UseVisualStyleBackColor = true;
            this.buttonGetImagePath.Click += new System.EventHandler(this.buttonGetImagePath_Click);
            // 
            // pictureBoxDisplayImage
            // 
            this.pictureBoxDisplayImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxDisplayImage.Location = new System.Drawing.Point(12, 51);
            this.pictureBoxDisplayImage.Name = "pictureBoxDisplayImage";
            this.pictureBoxDisplayImage.Size = new System.Drawing.Size(812, 694);
            this.pictureBoxDisplayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplayImage.TabIndex = 2;
            this.pictureBoxDisplayImage.TabStop = false;
            // 
            // button2GrayImage
            // 
            this.button2GrayImage.Location = new System.Drawing.Point(6, 32);
            this.button2GrayImage.Name = "button2GrayImage";
            this.button2GrayImage.Size = new System.Drawing.Size(137, 47);
            this.button2GrayImage.TabIndex = 3;
            this.button2GrayImage.Text = "影像灰階";
            this.button2GrayImage.UseVisualStyleBackColor = true;
            this.button2GrayImage.Click += new System.EventHandler(this.button2GrayImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2GrayImage);
            this.groupBox1.Location = new System.Drawing.Point(830, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 693);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影像處理";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 756);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxDisplayImage);
            this.Controls.Add(this.buttonGetImagePath);
            this.Controls.Add(this.textBoxImagePath);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.Button buttonGetImagePath;
        private System.Windows.Forms.PictureBox pictureBoxDisplayImage;
        private System.Windows.Forms.Button button2GrayImage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

