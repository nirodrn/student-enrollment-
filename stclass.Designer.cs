namespace SESys
{
    partial class stclass
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
            label1 = new Label();
            label2 = new Label();
            lblstudentinfo = new Label();
            listBoxCoursetime = new ListBox();
            comboBoxregno = new ComboBox();
            comboBoxcoursdetails = new ComboBox();
            btnassign = new Button();
            btnclear = new Button();
            btnsave = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            listBoxstudentcources = new ListBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 51);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "Select Reg No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 94);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 2;
            label2.Text = "Student Info";
            label2.Click += label2_Click;
            // 
            // lblstudentinfo
            // 
            lblstudentinfo.AutoSize = true;
            lblstudentinfo.Location = new Point(277, 94);
            lblstudentinfo.Name = "lblstudentinfo";
            lblstudentinfo.Size = new Size(40, 25);
            lblstudentinfo.TabIndex = 3;
            lblstudentinfo.Text = ".......";
            // 
            // listBoxCoursetime
            // 
            listBoxCoursetime.FormattingEnabled = true;
            listBoxCoursetime.ItemHeight = 25;
            listBoxCoursetime.Location = new Point(534, 136);
            listBoxCoursetime.Name = "listBoxCoursetime";
            listBoxCoursetime.Size = new Size(251, 79);
            listBoxCoursetime.TabIndex = 4;
            // 
            // comboBoxregno
            // 
            comboBoxregno.FormattingEnabled = true;
            comboBoxregno.Location = new Point(275, 48);
            comboBoxregno.Name = "comboBoxregno";
            comboBoxregno.Size = new Size(253, 33);
            comboBoxregno.TabIndex = 5;
            comboBoxregno.SelectedIndexChanged += comboBoxregno_SelectedIndexChanged;
            // 
            // comboBoxcoursdetails
            // 
            comboBoxcoursdetails.FormattingEnabled = true;
            comboBoxcoursdetails.Location = new Point(277, 136);
            comboBoxcoursdetails.Name = "comboBoxcoursdetails";
            comboBoxcoursdetails.Size = new Size(251, 33);
            comboBoxcoursdetails.TabIndex = 6;
            comboBoxcoursdetails.SelectedIndexChanged += comboBoxcoursdetails_SelectedIndexChanged;
            // 
            // btnassign
            // 
            btnassign.Location = new Point(277, 175);
            btnassign.Name = "btnassign";
            btnassign.Size = new Size(251, 40);
            btnassign.TabIndex = 7;
            btnassign.Text = "Assign the courses";
            btnassign.UseVisualStyleBackColor = true;
            btnassign.Click += btnassign_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(833, 221);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(115, 41);
            btnclear.TabIndex = 8;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(788, 327);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(160, 41);
            btnsave.TabIndex = 9;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(833, 280);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(115, 41);
            btndelete.TabIndex = 10;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(622, 327);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(160, 41);
            btnupdate.TabIndex = 11;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // listBoxstudentcources
            // 
            listBoxstudentcources.FormattingEnabled = true;
            listBoxstudentcources.ItemHeight = 25;
            listBoxstudentcources.Location = new Point(277, 221);
            listBoxstudentcources.Name = "listBoxstudentcources";
            listBoxstudentcources.Size = new Size(339, 79);
            listBoxstudentcources.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 144);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 13;
            label3.Text = "select cource ";
            // 
            // button1
            // 
            button1.Location = new Point(622, 222);
            button1.Name = "button1";
            button1.Size = new Size(163, 78);
            button1.TabIndex = 14;
            button1.Text = "Remove ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // stclass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 380);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(listBoxstudentcources);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(btnsave);
            Controls.Add(btnclear);
            Controls.Add(btnassign);
            Controls.Add(comboBoxcoursdetails);
            Controls.Add(comboBoxregno);
            Controls.Add(listBoxCoursetime);
            Controls.Add(lblstudentinfo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "stclass";
            Text = "stclass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblstudentinfo;
        private ListBox listBoxCoursetime;
        private ComboBox comboBoxregno;
        private ComboBox comboBoxcoursdetails;
        private Button btnassign;
        private Button btnclear;
        private Button btnsave;
        private Button btndelete;
        private Button btnupdate;
        private ListBox listBoxstudentcources;
        private Label label3;
        private Button button1;
    }
}