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
            this.buttonChannelBlue = new System.Windows.Forms.Button();
            this.buttonChannelGreen = new System.Windows.Forms.Button();
            this.buttonChannelRed = new System.Windows.Forms.Button();
            this.buttonKeepRed = new System.Windows.Forms.Button();
            this.buttonKeepGreen = new System.Windows.Forms.Button();
            this.buttonKeepBlue = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.buttonKeepRed);
            this.groupBox1.Controls.Add(this.buttonKeepGreen);
            this.groupBox1.Controls.Add(this.buttonKeepBlue);
            this.groupBox1.Controls.Add(this.buttonChannelRed);
            this.groupBox1.Controls.Add(this.buttonChannelGreen);
            this.groupBox1.Controls.Add(this.buttonChannelBlue);
            this.groupBox1.Controls.Add(this.button2GrayImage);
            this.groupBox1.Location = new System.Drawing.Point(830, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 693);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影像處理";
            // 
            // buttonChannelBlue
            // 
            this.buttonChannelBlue.Location = new System.Drawing.Point(6, 97);
            this.buttonChannelBlue.Name = "buttonChannelBlue";
            this.buttonChannelBlue.Size = new System.Drawing.Size(137, 47);
            this.buttonChannelBlue.TabIndex = 4;
            this.buttonChannelBlue.Text = "藍";
            this.buttonChannelBlue.UseVisualStyleBackColor = true;
            this.buttonChannelBlue.Click += new System.EventHandler(this.buttonChannelBlue_Click);
            // 
            // buttonChannelGreen
            // 
            this.buttonChannelGreen.Location = new System.Drawing.Point(149, 97);
            this.buttonChannelGreen.Name = "buttonChannelGreen";
            this.buttonChannelGreen.Size = new System.Drawing.Size(137, 47);
            this.buttonChannelGreen.TabIndex = 5;
            this.buttonChannelGreen.Text = "綠";
            this.buttonChannelGreen.UseVisualStyleBackColor = true;
            this.buttonChannelGreen.Click += new System.EventHandler(this.buttonChannelGreen_Click);
            // 
            // buttonChannelRed
            // 
            this.buttonChannelRed.Location = new System.Drawing.Point(292, 97);
            this.buttonChannelRed.Name = "buttonChannelRed";
            this.buttonChannelRed.Size = new System.Drawing.Size(137, 47);
            this.buttonChannelRed.TabIndex = 6;
            this.buttonChannelRed.Text = "紅";
            this.buttonChannelRed.UseVisualStyleBackColor = true;
            this.buttonChannelRed.Click += new System.EventHandler(this.buttonChannelRed_Click);
            // 
            // buttonKeepRed
            // 
            this.buttonKeepRed.Location = new System.Drawing.Point(292, 161);
            this.buttonKeepRed.Name = "buttonKeepRed";
            this.buttonKeepRed.Size = new System.Drawing.Size(137, 47);
            this.buttonKeepRed.TabIndex = 9;
            this.buttonKeepRed.Text = "保留紅";
            this.buttonKeepRed.UseVisualStyleBackColor = true;
            this.buttonKeepRed.Click += new System.EventHandler(this.buttonKeepRed_Click);
            // 
            // buttonKeepGreen
            // 
            this.buttonKeepGreen.Location = new System.Drawing.Point(149, 161);
            this.buttonKeepGreen.Name = "buttonKeepGreen";
            this.buttonKeepGreen.Size = new System.Drawing.Size(137, 47);
            this.buttonKeepGreen.TabIndex = 8;
            this.buttonKeepGreen.Text = "保留綠";
            this.buttonKeepGreen.UseVisualStyleBackColor = true;
            this.buttonKeepGreen.Click += new System.EventHandler(this.buttonKeepGreen_Click);
            // 
            // buttonKeepBlue
            // 
            this.buttonKeepBlue.Location = new System.Drawing.Point(6, 161);
            this.buttonKeepBlue.Name = "buttonKeepBlue";
            this.buttonKeepBlue.Size = new System.Drawing.Size(137, 47);
            this.buttonKeepBlue.TabIndex = 7;
            this.buttonKeepBlue.Text = "保留藍";
            this.buttonKeepBlue.UseVisualStyleBackColor = true;
            this.buttonKeepBlue.Click += new System.EventHandler(this.buttonKeepBlue_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(12, 751);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(1264, 62);
            this.buttonSaveImage.TabIndex = 5;
            this.buttonSaveImage.Text = "保存影像";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 825);
            this.Controls.Add(this.buttonSaveImage);
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
        private System.Windows.Forms.Button buttonChannelRed;
        private System.Windows.Forms.Button buttonChannelGreen;
        private System.Windows.Forms.Button buttonChannelBlue;
        private System.Windows.Forms.Button buttonKeepRed;
        private System.Windows.Forms.Button buttonKeepGreen;
        private System.Windows.Forms.Button buttonKeepBlue;
        private System.Windows.Forms.Button buttonSaveImage;
    }
}

