
namespace Student_Information_System
{
    partial class Attendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.lessonlabel1 = new System.Windows.Forms.Label();
            this.lessonlabel2 = new System.Windows.Forms.Label();
            this.lessonlabel3 = new System.Windows.Forms.Label();
            this.absence_box = new System.Windows.Forms.TextBox();
            this.absence2_box = new System.Windows.Forms.TextBox();
            this.absence3_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.absentwarning_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit your Attendance";
            // 
            // lessonlabel1
            // 
            this.lessonlabel1.AutoSize = true;
            this.lessonlabel1.BackColor = System.Drawing.Color.Transparent;
            this.lessonlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lessonlabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.lessonlabel1.Location = new System.Drawing.Point(27, 67);
            this.lessonlabel1.Name = "lessonlabel1";
            this.lessonlabel1.Size = new System.Drawing.Size(60, 24);
            this.lessonlabel1.TabIndex = 1;
            this.lessonlabel1.Text = "label2";
            // 
            // lessonlabel2
            // 
            this.lessonlabel2.AutoSize = true;
            this.lessonlabel2.BackColor = System.Drawing.Color.Transparent;
            this.lessonlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lessonlabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.lessonlabel2.Location = new System.Drawing.Point(27, 131);
            this.lessonlabel2.Name = "lessonlabel2";
            this.lessonlabel2.Size = new System.Drawing.Size(60, 24);
            this.lessonlabel2.TabIndex = 2;
            this.lessonlabel2.Text = "label3";
            // 
            // lessonlabel3
            // 
            this.lessonlabel3.AutoSize = true;
            this.lessonlabel3.BackColor = System.Drawing.Color.Transparent;
            this.lessonlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lessonlabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.lessonlabel3.Location = new System.Drawing.Point(27, 196);
            this.lessonlabel3.Name = "lessonlabel3";
            this.lessonlabel3.Size = new System.Drawing.Size(60, 24);
            this.lessonlabel3.TabIndex = 3;
            this.lessonlabel3.Text = "label4";
            // 
            // absence_box
            // 
            this.absence_box.Location = new System.Drawing.Point(176, 67);
            this.absence_box.Name = "absence_box";
            this.absence_box.Size = new System.Drawing.Size(100, 22);
            this.absence_box.TabIndex = 4;
            // 
            // absence2_box
            // 
            this.absence2_box.Location = new System.Drawing.Point(176, 131);
            this.absence2_box.Name = "absence2_box";
            this.absence2_box.Size = new System.Drawing.Size(100, 22);
            this.absence2_box.TabIndex = 5;
            // 
            // absence3_box
            // 
            this.absence3_box.Location = new System.Drawing.Point(176, 191);
            this.absence3_box.Name = "absence3_box";
            this.absence3_box.Size = new System.Drawing.Size(100, 22);
            this.absence3_box.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(299, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // absentwarning_label
            // 
            this.absentwarning_label.AutoSize = true;
            this.absentwarning_label.BackColor = System.Drawing.Color.Transparent;
            this.absentwarning_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.absentwarning_label.ForeColor = System.Drawing.Color.Red;
            this.absentwarning_label.Location = new System.Drawing.Point(12, 250);
            this.absentwarning_label.Name = "absentwarning_label";
            this.absentwarning_label.Size = new System.Drawing.Size(336, 25);
            this.absentwarning_label.TabIndex = 8;
            this.absentwarning_label.Text = "Attendance should between 0-30!";
            this.absentwarning_label.Visible = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(299, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(299, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Information_System.Properties.Resources.backgroundDefault;
            this.ClientSize = new System.Drawing.Size(386, 333);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.absentwarning_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.absence3_box);
            this.Controls.Add(this.absence2_box);
            this.Controls.Add(this.absence_box);
            this.Controls.Add(this.lessonlabel3);
            this.Controls.Add(this.lessonlabel2);
            this.Controls.Add(this.lessonlabel1);
            this.Controls.Add(this.label1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.AbsentLimit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lessonlabel1;
        private System.Windows.Forms.Label lessonlabel2;
        private System.Windows.Forms.Label lessonlabel3;
        private System.Windows.Forms.TextBox absence_box;
        private System.Windows.Forms.TextBox absence2_box;
        private System.Windows.Forms.TextBox absence3_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label absentwarning_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}