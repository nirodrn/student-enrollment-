namespace SESys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbxuser = new TextBox();
            tbxpass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnlogin = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbxuser
            // 
            tbxuser.Location = new Point(607, 167);
            tbxuser.Name = "tbxuser";
            tbxuser.Size = new Size(288, 31);
            tbxuser.TabIndex = 0;
            // 
            // tbxpass
            // 
            tbxpass.Location = new Point(607, 237);
            tbxpass.Name = "tbxpass";
            tbxpass.Size = new Size(288, 31);
            tbxpass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(701, 65);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(607, 139);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(607, 209);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.PeachPuff;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Location = new Point(795, 298);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(100, 36);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.students_2995620;
            pictureBox1.Location = new Point(158, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stacker", 15.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(212, 347);
            label4.Name = "label4";
            label4.Size = new Size(151, 43);
            label4.TabIndex = 7;
            label4.Text = "STsys";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(937, 9);
            label5.Name = "label5";
            label5.Size = new Size(39, 25);
            label5.TabIndex = 8;
            label5.Text = "Exit";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(858, 9);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 9;
            label6.Text = "About";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2021_12_25_mac_OS_Big_Sur;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnlogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxpass);
            Controls.Add(tbxuser);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "STsys";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxuser;
        private TextBox tbxpass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnlogin;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}