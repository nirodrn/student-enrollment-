namespace SESys
{
    partial class studentinfoshow
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
            comboBoxregno = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lblfullname = new Label();
            label4 = new Label();
            Birthday = new Label();
            listBoxClasses = new ListBox();
            lblgender = new Label();
            lblage = new Label();
            Classes = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxregno
            // 
            comboBoxregno.FormattingEnabled = true;
            comboBoxregno.Location = new Point(221, 41);
            comboBoxregno.Name = "comboBoxregno";
            comboBoxregno.Size = new Size(324, 33);
            comboBoxregno.TabIndex = 0;
            comboBoxregno.SelectedIndexChanged += comboBoxregno_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 44);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "Select Reg No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 96);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // lblfullname
            // 
            lblfullname.AutoSize = true;
            lblfullname.Location = new Point(221, 96);
            lblfullname.Name = "lblfullname";
            lblfullname.Size = new Size(36, 25);
            lblfullname.TabIndex = 3;
            lblfullname.Text = "......";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 133);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 4;
            label4.Text = "Gender";
            // 
            // Birthday
            // 
            Birthday.AutoSize = true;
            Birthday.Location = new Point(39, 168);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(44, 25);
            Birthday.TabIndex = 5;
            Birthday.Text = "Age";
            // 
            // listBoxClasses
            // 
            listBoxClasses.FormattingEnabled = true;
            listBoxClasses.ItemHeight = 25;
            listBoxClasses.Location = new Point(221, 236);
            listBoxClasses.Name = "listBoxClasses";
            listBoxClasses.Size = new Size(324, 104);
            listBoxClasses.TabIndex = 6;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(221, 133);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(36, 25);
            lblgender.TabIndex = 7;
            lblgender.Text = "......";
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Location = new Point(221, 168);
            lblage.Name = "lblage";
            lblage.Size = new Size(36, 25);
            lblage.TabIndex = 8;
            lblage.Text = "......";
            // 
            // Classes
            // 
            Classes.AutoSize = true;
            Classes.Location = new Point(39, 236);
            Classes.Name = "Classes";
            Classes.Size = new Size(69, 25);
            Classes.TabIndex = 9;
            Classes.Text = "Classes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(594, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(621, 374);
            dataGridView1.TabIndex = 14;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // studentinfoshow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 395);
            Controls.Add(dataGridView1);
            Controls.Add(Classes);
            Controls.Add(lblage);
            Controls.Add(lblgender);
            Controls.Add(listBoxClasses);
            Controls.Add(Birthday);
            Controls.Add(label4);
            Controls.Add(lblfullname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxregno);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "studentinfoshow";
            Text = "Student Info";
            Load += studentinfoshow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxregno;
        private Label label1;
        private Label label2;
        private Label lblfullname;
        private Label label4;
        private Label Birthday;
        private ListBox listBoxClasses;
        private Label lblgender;
        private Label lblage;
        private Label Classes;
        private DataGridView dataGridView1;
    }
}