namespace QLKTXWindowsForms
{
    partial class FormRegesterStudent
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelParentPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxParentPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelStudentCode = new System.Windows.Forms.Label();
            this.textBoxStudentCode = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDHID = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.comboBoxMaDH = new System.Windows.Forms.ComboBox();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(173, 25);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(257, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Đăng Ký Sinh Viên";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(67, 86);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(67, 16);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Họ và tên:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(200, 82);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(332, 22);
            this.textBoxFullName.TabIndex = 2;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(67, 135);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(70, 16);
            this.labelDateOfBirth.TabIndex = 3;
            this.labelDateOfBirth.Text = "Ngày sinh:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(67, 185);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(57, 16);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Giới tính:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGender.Location = new System.Drawing.Point(200, 181);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(332, 24);
            this.comboBoxGender.TabIndex = 6;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(67, 234);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(88, 16);
            this.labelPhoneNumber.TabIndex = 7;
            this.labelPhoneNumber.Text = "Số điện thoại:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(200, 230);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(332, 22);
            this.textBoxPhoneNumber.TabIndex = 8;
            // 
            // labelParentPhoneNumber
            // 
            this.labelParentPhoneNumber.AutoSize = true;
            this.labelParentPhoneNumber.Location = new System.Drawing.Point(67, 283);
            this.labelParentPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParentPhoneNumber.Name = "labelParentPhoneNumber";
            this.labelParentPhoneNumber.Size = new System.Drawing.Size(110, 16);
            this.labelParentPhoneNumber.TabIndex = 9;
            this.labelParentPhoneNumber.Text = "Số điện thoại PH:";
            // 
            // textBoxParentPhoneNumber
            // 
            this.textBoxParentPhoneNumber.Location = new System.Drawing.Point(200, 279);
            this.textBoxParentPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxParentPhoneNumber.Name = "textBoxParentPhoneNumber";
            this.textBoxParentPhoneNumber.Size = new System.Drawing.Size(332, 22);
            this.textBoxParentPhoneNumber.TabIndex = 10;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(67, 332);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(200, 329);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(332, 22);
            this.textBoxEmail.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(67, 382);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 16);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Mật khẩu:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(200, 378);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(332, 22);
            this.textBoxPassword.TabIndex = 14;
            // 
            // labelStudentCode
            // 
            this.labelStudentCode.AutoSize = true;
            this.labelStudentCode.Location = new System.Drawing.Point(67, 431);
            this.labelStudentCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentCode.Name = "labelStudentCode";
            this.labelStudentCode.Size = new System.Drawing.Size(84, 16);
            this.labelStudentCode.TabIndex = 15;
            this.labelStudentCode.Text = "Mã sinh viên:";
            // 
            // textBoxStudentCode
            // 
            this.textBoxStudentCode.Location = new System.Drawing.Point(200, 427);
            this.textBoxStudentCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentCode.Name = "textBoxStudentCode";
            this.textBoxStudentCode.Size = new System.Drawing.Size(332, 22);
            this.textBoxStudentCode.TabIndex = 16;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(267, 640);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(133, 37);
            this.buttonRegister.TabIndex = 23;
            this.buttonRegister.Text = "Đăng ký";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 652);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDHID
            // 
            this.labelDHID.AutoSize = true;
            this.labelDHID.Location = new System.Drawing.Point(67, 480);
            this.labelDHID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDHID.Name = "labelDHID";
            this.labelDHID.Size = new System.Drawing.Size(52, 16);
            this.labelDHID.TabIndex = 17;
            this.labelDHID.Text = "Mã DH:";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(67, 529);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(41, 16);
            this.labelDepartment.TabIndex = 19;
            this.labelDepartment.Text = "Khoa:";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(67, 578);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(33, 16);
            this.labelClass.TabIndex = 21;
            this.labelClass.Text = "Lớp:";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(200, 575);
            this.textBoxClass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(332, 22);
            this.textBoxClass.TabIndex = 22;
            // 
            // comboBoxMaDH
            // 
            this.comboBoxMaDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaDH.FormattingEnabled = true;
            this.comboBoxMaDH.Location = new System.Drawing.Point(200, 472);
            this.comboBoxMaDH.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaDH.Name = "comboBoxMaDH";
            this.comboBoxMaDH.Size = new System.Drawing.Size(332, 24);
            this.comboBoxMaDH.TabIndex = 25;
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(200, 521);
            this.comboBoxKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(332, 24);
            this.comboBoxKhoa.TabIndex = 26;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(200, 129);
            this.dateTimePickerDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDateOfBirth.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(332, 22);
            this.dateTimePickerDateOfBirth.TabIndex = 27;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2023, 3, 19, 4, 49, 16, 0);
            // 
            // FormRegesterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 702);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.comboBoxKhoa);
            this.Controls.Add(this.comboBoxMaDH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelDHID);
            this.Controls.Add(this.textBoxStudentCode);
            this.Controls.Add(this.labelStudentCode);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxParentPhoneNumber);
            this.Controls.Add(this.labelParentPhoneNumber);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegesterStudent";
            this.Text = "Đăng ký sinh viên";
            this.Load += new System.EventHandler(this.FormRegesterStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelParentPhoneNumber;
        private System.Windows.Forms.TextBox textBoxParentPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelStudentCode;
        private System.Windows.Forms.TextBox textBoxStudentCode;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDHID;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.ComboBox comboBoxMaDH;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
    }
}
