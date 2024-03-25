namespace SESys
{
    partial class courses
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
            comboBoxcourseName = new ComboBox();
            comboBoxdays = new ComboBox();
            tbxstarTime = new TextBox();
            tbxendTime = new TextBox();
            btnAddToListbox = new Button();
            listBoxCourseTime = new ListBox();
            btnremovefromListbox = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnsave = new Button();
            btnUpdate = new Button();
            button1 = new Button();
            btndelete = new Button();
            SuspendLayout();
            // 
            // comboBoxcourseName
            // 
            comboBoxcourseName.FormattingEnabled = true;
            comboBoxcourseName.Location = new Point(240, 27);
            comboBoxcourseName.Name = "comboBoxcourseName";
            comboBoxcourseName.Size = new Size(502, 33);
            comboBoxcourseName.TabIndex = 1;
            comboBoxcourseName.SelectedIndexChanged += comboBoxcourseName_SelectedIndexChanged;
            // 
            // comboBoxdays
            // 
            comboBoxdays.FormattingEnabled = true;
            comboBoxdays.Location = new Point(240, 100);
            comboBoxdays.Name = "comboBoxdays";
            comboBoxdays.Size = new Size(154, 33);
            comboBoxdays.TabIndex = 2;
            // 
            // tbxstarTime
            // 
            tbxstarTime.Location = new Point(400, 102);
            tbxstarTime.Name = "tbxstarTime";
            tbxstarTime.Size = new Size(169, 31);
            tbxstarTime.TabIndex = 3;
            // 
            // tbxendTime
            // 
            tbxendTime.Location = new Point(575, 102);
            tbxendTime.Name = "tbxendTime";
            tbxendTime.Size = new Size(167, 31);
            tbxendTime.TabIndex = 4;
            // 
            // btnAddToListbox
            // 
            btnAddToListbox.Location = new Point(606, 143);
            btnAddToListbox.Name = "btnAddToListbox";
            btnAddToListbox.Size = new Size(136, 39);
            btnAddToListbox.TabIndex = 5;
            btnAddToListbox.Text = "Add";
            btnAddToListbox.UseVisualStyleBackColor = true;
            btnAddToListbox.Click += btnAddToListbox_Click;
            // 
            // listBoxCourseTime
            // 
            listBoxCourseTime.FormattingEnabled = true;
            listBoxCourseTime.ItemHeight = 25;
            listBoxCourseTime.Location = new Point(240, 147);
            listBoxCourseTime.Name = "listBoxCourseTime";
            listBoxCourseTime.Size = new Size(360, 129);
            listBoxCourseTime.TabIndex = 6;
            // 
            // btnremovefromListbox
            // 
            btnremovefromListbox.Location = new Point(606, 188);
            btnremovefromListbox.Name = "btnremovefromListbox";
            btnremovefromListbox.Size = new Size(136, 39);
            btnremovefromListbox.TabIndex = 7;
            btnremovefromListbox.Text = "Remove";
            btnremovefromListbox.UseVisualStyleBackColor = true;
            btnremovefromListbox.Click += btnremovefromListbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 8;
            label1.Text = "Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 108);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 10;
            label3.Text = "Date and Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 72);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 11;
            label4.Text = "Start Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(606, 72);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 12;
            label5.Text = "End Time";
            // 
            // btnsave
            // 
            btnsave.Location = new Point(798, 261);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(136, 49);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(798, 212);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 39);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(606, 233);
            button1.Name = "button1";
            button1.Size = new Size(136, 39);
            button1.TabIndex = 15;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(798, 167);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(136, 39);
            btndelete.TabIndex = 16;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // courses
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 322);
            Controls.Add(btndelete);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(btnsave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnremovefromListbox);
            Controls.Add(listBoxCourseTime);
            Controls.Add(btnAddToListbox);
            Controls.Add(tbxendTime);
            Controls.Add(tbxstarTime);
            Controls.Add(comboBoxdays);
            Controls.Add(comboBoxcourseName);
            Name = "courses";
            Text = "courses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxcourseName;
        private ComboBox comboBoxdays;
        private TextBox tbxstarTime;
        private TextBox tbxendTime;
        private Button btnAddToListbox;
        private ListBox listBoxCourseTime;
        private Button btnremovefromListbox;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnsave;
        private Button btnUpdate;
        private Button button1;
        private Button btndelete;
    }
}