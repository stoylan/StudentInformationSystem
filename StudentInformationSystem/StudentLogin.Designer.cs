namespace Student_Information_System
{
    partial class StudentLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(451, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.BackgroundImage = global::Student_Information_System.Properties.Resources.Button_Previous_icon__1_;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backButton.Location = new System.Drawing.Point(205, 340);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 128);
            this.backButton.TabIndex = 7;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usernameText.Location = new System.Drawing.Point(252, 175);
            this.usernameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(154, 31);
            this.usernameText.TabIndex = 8;
            this.usernameText.Text = "Username :";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordText.Location = new System.Drawing.Point(252, 239);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(149, 31);
            this.passwordText.TabIndex = 9;
            this.passwordText.Text = "Password :";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Control;
            this.loginButton.BackgroundImage = global::Student_Information_System.Properties.Resources.logout_icon;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Location = new System.Drawing.Point(731, 340);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(127, 128);
            this.loginButton.TabIndex = 10;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LogoPic
            // 
            this.LogoPic.BackgroundImage = global::Student_Information_System.Properties.Resources.logo72px;
            this.LogoPic.Location = new System.Drawing.Point(48, 26);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(71, 73);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoPic.TabIndex = 11;
            this.LogoPic.TabStop = false;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameBox.Location = new System.Drawing.Point(516, 175);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(253, 34);
            this.UsernameBox.TabIndex = 12;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordBox.Location = new System.Drawing.Point(516, 239);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(253, 34);
            this.PasswordBox.TabIndex = 13;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged_1);
            // 
            // registerButton
            // 
            this.registerButton.BackgroundImage = global::Student_Information_System.Properties.Resources.Register_button;
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Location = new System.Drawing.Point(454, 340);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(128, 128);
            this.registerButton.TabIndex = 14;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(841, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(841, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.Load += new System.EventHandler(this.StudentLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}