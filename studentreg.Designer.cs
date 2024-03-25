namespace SESys
{
    partial class studentreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentreg));
            comboBoxregno = new ComboBox();
            tbxFname = new TextBox();
            tbxLname = new TextBox();
            tbxparentaddress = new TextBox();
            tbxparentNIC = new TextBox();
            tbxparentContactno = new TextBox();
            tbxhomephoneNo = new TextBox();
            tbxNIC = new TextBox();
            tbxstudentcontact = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            btnsave = new Button();
            btnUpdate = new Button();
            btndelete = new Button();
            btnclear = new Button();
            label1 = new Label();
            label2 = new Label();
            btnGenerateRegNo = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbxparentfullname = new TextBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // comboBoxregno
            // 
            comboBoxregno.FormattingEnabled = true;
            comboBoxregno.Location = new Point(211, 95);
            comboBoxregno.Name = "comboBoxregno";
            comboBoxregno.Size = new Size(219, 33);
            comboBoxregno.TabIndex = 0;
            comboBoxregno.SelectedIndexChanged += comboBoxregno_SelectedIndexChanged;
            // 
            // tbxFname
            // 
            tbxFname.Location = new Point(211, 134);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(348, 31);
            tbxFname.TabIndex = 1;
            // 
            // tbxLname
            // 
            tbxLname.Location = new Point(211, 171);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(348, 31);
            tbxLname.TabIndex = 2;
            // 
            // tbxparentaddress
            // 
            tbxparentaddress.Location = new Point(820, 123);
            tbxparentaddress.Multiline = true;
            tbxparentaddress.Name = "tbxparentaddress";
            tbxparentaddress.Size = new Size(348, 73);
            tbxparentaddress.TabIndex = 3;
            // 
            // tbxparentNIC
            // 
            tbxparentNIC.Location = new Point(820, 202);
            tbxparentNIC.Name = "tbxparentNIC";
            tbxparentNIC.Size = new Size(348, 31);
            tbxparentNIC.TabIndex = 4;
            // 
            // tbxparentContactno
            // 
            tbxparentContactno.Location = new Point(820, 239);
            tbxparentContactno.Name = "tbxparentContactno";
            tbxparentContactno.Size = new Size(348, 31);
            tbxparentContactno.TabIndex = 5;
            // 
            // tbxhomephoneNo
            // 
            tbxhomephoneNo.Location = new Point(820, 276);
            tbxhomephoneNo.Name = "tbxhomephoneNo";
            tbxhomephoneNo.Size = new Size(348, 31);
            tbxhomephoneNo.TabIndex = 6;
            // 
            // tbxNIC
            // 
            tbxNIC.Location = new Point(211, 211);
            tbxNIC.Name = "tbxNIC";
            tbxNIC.Size = new Size(348, 31);
            tbxNIC.TabIndex = 7;
            // 
            // tbxstudentcontact
            // 
            tbxstudentcontact.Location = new Point(211, 255);
            tbxstudentcontact.Name = "tbxstudentcontact";
            tbxstudentcontact.Size = new Size(348, 31);
            tbxstudentcontact.TabIndex = 8;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(211, 312);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(348, 31);
            dateTimePickerDOB.TabIndex = 9;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(211, 370);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 29);
            rdoMale.TabIndex = 10;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(387, 370);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(93, 29);
            rdoFemale.TabIndex = 11;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(1045, 357);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(123, 42);
            btnsave.TabIndex = 12;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1045, 312);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 42);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(916, 357);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(123, 42);
            btndelete.TabIndex = 14;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(916, 312);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(123, 42);
            btnclear.TabIndex = 15;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(436, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 38);
            label1.TabIndex = 16;
            label1.Text = "Student Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 95);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 17;
            label2.Text = "Reg No";
            // 
            // btnGenerateRegNo
            // 
            btnGenerateRegNo.Location = new Point(436, 95);
            btnGenerateRegNo.Name = "btnGenerateRegNo";
            btnGenerateRegNo.Size = new Size(123, 33);
            btnGenerateRegNo.TabIndex = 18;
            btnGenerateRegNo.Text = "Generate No";
            btnGenerateRegNo.UseVisualStyleBackColor = true;
            btnGenerateRegNo.Click += btnGenerateRegNo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 134);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 19;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 171);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 20;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 261);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 21;
            label5.Text = "Contact NO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 211);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 22;
            label6.Text = "NIC No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 317);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 23;
            label7.Text = "Date Of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 370);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 24;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(640, 131);
            label9.Name = "label9";
            label9.Size = new Size(128, 25);
            label9.TabIndex = 25;
            label9.Text = "Parent address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(640, 202);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 26;
            label10.Text = "Parent  Nic";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(640, 242);
            label11.Name = "label11";
            label11.Size = new Size(159, 25);
            label11.TabIndex = 27;
            label11.Text = "Parent Contact NO";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(640, 276);
            label12.Name = "label12";
            label12.Size = new Size(145, 25);
            label12.TabIndex = 28;
            label12.Text = "Home Phone No";
            // 
            // tbxparentfullname
            // 
            tbxparentfullname.Location = new Point(820, 86);
            tbxparentfullname.Name = "tbxparentfullname";
            tbxparentfullname.Size = new Size(348, 31);
            tbxparentfullname.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(640, 89);
            label13.Name = "label13";
            label13.Size = new Size(145, 25);
            label13.TabIndex = 30;
            label13.Text = "Parent Full Name";
            // 
            // studentreg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 432);
            Controls.Add(label13);
            Controls.Add(tbxparentfullname);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnGenerateRegNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnsave);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(tbxstudentcontact);
            Controls.Add(tbxNIC);
            Controls.Add(tbxhomephoneNo);
            Controls.Add(tbxparentContactno);
            Controls.Add(tbxparentNIC);
            Controls.Add(tbxparentaddress);
            Controls.Add(tbxLname);
            Controls.Add(tbxFname);
            Controls.Add(comboBoxregno);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "studentreg";
            Text = "STSYS ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxregno;
        private TextBox tbxFname;
        private TextBox tbxLname;
        private TextBox tbxparentaddress;
        private TextBox tbxparentNIC;
        private TextBox tbxparentContactno;
        private TextBox tbxhomephoneNo;
        private TextBox tbxNIC;
        private TextBox tbxstudentcontact;
        private DateTimePicker dateTimePickerDOB;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Button btnsave;
        private Button btnUpdate;
        private Button btndelete;
        private Button btnclear;
        private Label label1;
        private Label label2;
        private Button btnGenerateRegNo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbxparentfullname;
        private Label label13;
    }
}