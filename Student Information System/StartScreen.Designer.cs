namespace Student_Information_System
{
    partial class StartScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.StudentLoginButton = new System.Windows.Forms.Button();
            this.TeacherLoginButton = new System.Windows.Forms.Button();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentLoginButton
            // 
            this.StudentLoginButton.BackgroundImage = global::Student_Information_System.Properties.Resources.clipart1828507;
            this.StudentLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StudentLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StudentLoginButton.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLoginButton.ForeColor = System.Drawing.Color.Black;
            this.StudentLoginButton.Image = global::Student_Information_System.Properties.Resources.graduated;
            this.StudentLoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentLoginButton.Location = new System.Drawing.Point(304, 90);
            this.StudentLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.StudentLoginButton.Name = "StudentLoginButton";
            this.StudentLoginButton.Size = new System.Drawing.Size(452, 160);
            this.StudentLoginButton.TabIndex = 0;
            this.StudentLoginButton.Text = "       STUDENT LOGIN";
            this.StudentLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentLoginButton.UseVisualStyleBackColor = true;
            this.StudentLoginButton.Click += new System.EventHandler(this.StudentLoginButton_Click);
            // 
            // TeacherLoginButton
            // 
            this.TeacherLoginButton.BackgroundImage = global::Student_Information_System.Properties.Resources.clipart1828507;
            this.TeacherLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TeacherLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeacherLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeacherLoginButton.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherLoginButton.Image = global::Student_Information_System.Properties.Resources.teacher;
            this.TeacherLoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TeacherLoginButton.Location = new System.Drawing.Point(304, 303);
            this.TeacherLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherLoginButton.Name = "TeacherLoginButton";
            this.TeacherLoginButton.Size = new System.Drawing.Size(452, 160);
            this.TeacherLoginButton.TabIndex = 1;
            this.TeacherLoginButton.Text = "        TEACHER LOGIN";
            this.TeacherLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TeacherLoginButton.UseVisualStyleBackColor = true;
            this.TeacherLoginButton.Click += new System.EventHandler(this.TeacherLoginButton_Click);
            // 
            // LogoPic
            // 
            this.LogoPic.BackgroundImage = global::Student_Information_System.Properties.Resources.logo72px;
            this.LogoPic.Location = new System.Drawing.Point(65, 23);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(71, 73);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoPic.TabIndex = 12;
            this.LogoPic.TabStop = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.TeacherLoginButton);
            this.Controls.Add(this.StudentLoginButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentLoginButton;
        private System.Windows.Forms.Button TeacherLoginButton;
        private System.Windows.Forms.PictureBox LogoPic;
    }
}

