namespace Mendoza_Mariela_Act_GUI
{
    partial class StudentForm
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
            StudentPictureBox = new PictureBox();
            AddImageBtn = new Button();
            ChangeImageBtn = new Button();
            StudentNameLabel = new Label();
            NameLabel = new Label();
            AgeLabel = new Label();
            StudentAgeLabel = new Label();
            AddressLabel = new Label();
            StudentAddressLabel = new Label();
            ContactLabel = new Label();
            StudentContactLabel = new Label();
            EmailLabel = new Label();
            StudentEmailLabel = new Label();
            CourseYearLabel = new Label();
            StudentCourseYearLabel = new Label();
            ParentNameLbl = new Label();
            ParentNameLabel = new Label();
            ParentContactLbl = new Label();
            ParentContactLabel = new Label();
            HobbiesLbl = new Label();
            HobbiesLabel = new Label();
            NicknameLbl = new Label();
            NicknameLabel = new Label();
            EditUpdateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // StudentPictureBox
            // 
            StudentPictureBox.BorderStyle = BorderStyle.FixedSingle;
            StudentPictureBox.Location = new Point(245, 9);
            StudentPictureBox.Margin = new Padding(3, 4, 3, 4);
            StudentPictureBox.Name = "StudentPictureBox";
            StudentPictureBox.Size = new Size(133, 121);
            StudentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            StudentPictureBox.TabIndex = 0;
            StudentPictureBox.TabStop = false;
            // 
            // AddImageBtn
            // 
            AddImageBtn.Location = new Point(390, 27);
            AddImageBtn.Margin = new Padding(3, 4, 3, 4);
            AddImageBtn.Name = "AddImageBtn";
            AddImageBtn.Size = new Size(96, 36);
            AddImageBtn.TabIndex = 1;
            AddImageBtn.Text = "Add Image";
            AddImageBtn.UseVisualStyleBackColor = true;
            AddImageBtn.Click += AddImageBtn_Click;
            // 
            // ChangeImageBtn
            // 
            ChangeImageBtn.Location = new Point(385, 70);
            ChangeImageBtn.Margin = new Padding(3, 4, 3, 4);
            ChangeImageBtn.Name = "ChangeImageBtn";
            ChangeImageBtn.Size = new Size(121, 33);
            ChangeImageBtn.TabIndex = 2;
            ChangeImageBtn.Text = "Change Image";
            ChangeImageBtn.UseVisualStyleBackColor = true;
            ChangeImageBtn.Click += ChangeImageBtn_Click;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentNameLabel.Location = new Point(373, 107);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(121, 20);
            StudentNameLabel.TabIndex = 3;
            StudentNameLabel.Text = "StudentName";
            StudentNameLabel.Click += StudentNameLabel_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(257, 113);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(54, 17);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name:";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgeLabel.Location = new Point(257, 138);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(41, 17);
            AgeLabel.TabIndex = 5;
            AgeLabel.Text = "Age:";
            // 
            // StudentAgeLabel
            // 
            StudentAgeLabel.AutoSize = true;
            StudentAgeLabel.Location = new Point(373, 138);
            StudentAgeLabel.Name = "StudentAgeLabel";
            StudentAgeLabel.Size = new Size(87, 20);
            StudentAgeLabel.TabIndex = 6;
            StudentAgeLabel.Text = "StudentAge";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressLabel.Location = new Point(257, 163);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(72, 17);
            AddressLabel.TabIndex = 7;
            AddressLabel.Text = "Address:";
            // 
            // StudentAddressLabel
            // 
            StudentAddressLabel.AutoSize = true;
            StudentAddressLabel.Location = new Point(373, 162);
            StudentAddressLabel.Name = "StudentAddressLabel";
            StudentAddressLabel.Size = new Size(113, 20);
            StudentAddressLabel.TabIndex = 8;
            StudentAddressLabel.Text = "StudentAddress";
            // 
            // ContactLabel
            // 
            ContactLabel.AutoSize = true;
            ContactLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactLabel.Location = new Point(257, 187);
            ContactLabel.Name = "ContactLabel";
            ContactLabel.Size = new Size(68, 17);
            ContactLabel.TabIndex = 9;
            ContactLabel.Text = "Contact:";
            // 
            // StudentContactLabel
            // 
            StudentContactLabel.AutoSize = true;
            StudentContactLabel.Location = new Point(373, 187);
            StudentContactLabel.Name = "StudentContactLabel";
            StudentContactLabel.Size = new Size(111, 20);
            StudentContactLabel.TabIndex = 10;
            StudentContactLabel.Text = "StudentContact";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(257, 213);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(52, 17);
            EmailLabel.TabIndex = 11;
            EmailLabel.Text = "Email:";
            // 
            // StudentEmailLabel
            // 
            StudentEmailLabel.AutoSize = true;
            StudentEmailLabel.Location = new Point(373, 213);
            StudentEmailLabel.Name = "StudentEmailLabel";
            StudentEmailLabel.Size = new Size(97, 20);
            StudentEmailLabel.TabIndex = 12;
            StudentEmailLabel.Text = "StudentEmail";
            // 
            // CourseYearLabel
            // 
            CourseYearLabel.AutoSize = true;
            CourseYearLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseYearLabel.Location = new Point(257, 238);
            CourseYearLabel.Name = "CourseYearLabel";
            CourseYearLabel.Size = new Size(108, 17);
            CourseYearLabel.TabIndex = 13;
            CourseYearLabel.Text = "Course & Year:";
            // 
            // StudentCourseYearLabel
            // 
            StudentCourseYearLabel.AutoSize = true;
            StudentCourseYearLabel.Location = new Point(373, 238);
            StudentCourseYearLabel.Name = "StudentCourseYearLabel";
            StudentCourseYearLabel.Size = new Size(133, 20);
            StudentCourseYearLabel.TabIndex = 14;
            StudentCourseYearLabel.Text = "StudentCourseYear";
            // 
            // ParentNameLbl
            // 
            ParentNameLbl.AutoSize = true;
            ParentNameLbl.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ParentNameLbl.Location = new Point(257, 263);
            ParentNameLbl.Name = "ParentNameLbl";
            ParentNameLbl.Size = new Size(107, 17);
            ParentNameLbl.TabIndex = 15;
            ParentNameLbl.Text = "Parent Name:";
            // 
            // ParentNameLabel
            // 
            ParentNameLabel.AutoSize = true;
            ParentNameLabel.Location = new Point(373, 263);
            ParentNameLabel.Name = "ParentNameLabel";
            ParentNameLabel.Size = new Size(90, 20);
            ParentNameLabel.TabIndex = 16;
            ParentNameLabel.Text = "ParentName";
            // 
            // ParentContactLbl
            // 
            ParentContactLbl.AutoSize = true;
            ParentContactLbl.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ParentContactLbl.Location = new Point(257, 289);
            ParentContactLbl.Name = "ParentContactLbl";
            ParentContactLbl.Size = new Size(121, 17);
            ParentContactLbl.TabIndex = 17;
            ParentContactLbl.Text = "Parent Contact:";
            // 
            // ParentContactLabel
            // 
            ParentContactLabel.AutoSize = true;
            ParentContactLabel.Location = new Point(373, 289);
            ParentContactLabel.Name = "ParentContactLabel";
            ParentContactLabel.Size = new Size(101, 20);
            ParentContactLabel.TabIndex = 18;
            ParentContactLabel.Text = "ParentContact";
            // 
            // HobbiesLbl
            // 
            HobbiesLbl.AutoSize = true;
            HobbiesLbl.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HobbiesLbl.Location = new Point(257, 313);
            HobbiesLbl.Name = "HobbiesLbl";
            HobbiesLbl.Size = new Size(72, 17);
            HobbiesLbl.TabIndex = 19;
            HobbiesLbl.Text = "Hobbies:";
            // 
            // HobbiesLabel
            // 
            HobbiesLabel.AutoSize = true;
            HobbiesLabel.Location = new Point(373, 313);
            HobbiesLabel.Name = "HobbiesLabel";
            HobbiesLabel.Size = new Size(65, 20);
            HobbiesLabel.TabIndex = 20;
            HobbiesLabel.Text = "Hobbies";
            // 
            // NicknameLbl
            // 
            NicknameLbl.AutoSize = true;
            NicknameLbl.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NicknameLbl.Location = new Point(257, 338);
            NicknameLbl.Name = "NicknameLbl";
            NicknameLbl.Size = new Size(83, 17);
            NicknameLbl.TabIndex = 21;
            NicknameLbl.Text = "Nickname:";
            // 
            // NicknameLabel
            // 
            NicknameLabel.AutoSize = true;
            NicknameLabel.Location = new Point(373, 337);
            NicknameLabel.Name = "NicknameLabel";
            NicknameLabel.Size = new Size(75, 20);
            NicknameLabel.TabIndex = 22;
            NicknameLabel.Text = "Nickname";
            // 
            // EditUpdateBtn
            // 
            EditUpdateBtn.BackColor = SystemColors.Info;
            EditUpdateBtn.Location = new Point(513, 493);
            EditUpdateBtn.Margin = new Padding(3, 4, 3, 4);
            EditUpdateBtn.Name = "EditUpdateBtn";
            EditUpdateBtn.Size = new Size(101, 29);
            EditUpdateBtn.TabIndex = 23;
            EditUpdateBtn.Text = "Edit/Update";
            EditUpdateBtn.UseVisualStyleBackColor = false;
            EditUpdateBtn.Click += EditUpdateBtn_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(667, 548);
            Controls.Add(EditUpdateBtn);
            Controls.Add(NicknameLabel);
            Controls.Add(NicknameLbl);
            Controls.Add(HobbiesLabel);
            Controls.Add(HobbiesLbl);
            Controls.Add(ParentContactLabel);
            Controls.Add(ParentContactLbl);
            Controls.Add(ParentNameLabel);
            Controls.Add(ParentNameLbl);
            Controls.Add(StudentCourseYearLabel);
            Controls.Add(CourseYearLabel);
            Controls.Add(StudentEmailLabel);
            Controls.Add(EmailLabel);
            Controls.Add(StudentContactLabel);
            Controls.Add(ContactLabel);
            Controls.Add(StudentAddressLabel);
            Controls.Add(AddressLabel);
            Controls.Add(StudentAgeLabel);
            Controls.Add(AgeLabel);
            Controls.Add(NameLabel);
            Controls.Add(StudentNameLabel);
            Controls.Add(ChangeImageBtn);
            Controls.Add(AddImageBtn);
            Controls.Add(StudentPictureBox);
            Name = "StudentForm";
            Text = "Student Page";
            ((System.ComponentModel.ISupportInitialize)StudentPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void UpdateStudentInfo(UserProfile userProfile)
        {
            StudentNameLabel.Text = userProfile.Name;
            StudentAgeLabel.Text = userProfile.Age.ToString();
            StudentAddressLabel.Text = userProfile.Address;
            StudentContactLabel.Text = userProfile.ContactNumber;
            StudentEmailLabel.Text = userProfile.Email;
            StudentCourseYearLabel.Text = $"{userProfile.Course} {userProfile.Year}";
            ParentNameLabel.Text = userProfile.ParentName;
            ParentContactLabel.Text = userProfile.ParentContact;
            HobbiesLabel.Text = userProfile.Hobbies;
            NicknameLabel.Text = userProfile.Nickname;
        }


        #endregion

        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.Button AddImageBtn;
        private System.Windows.Forms.Button ChangeImageBtn;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label StudentAgeLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label StudentAddressLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label StudentContactLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label StudentEmailLabel;
        private System.Windows.Forms.Label CourseYearLabel;
        private System.Windows.Forms.Label StudentCourseYearLabel;
        private System.Windows.Forms.Label ParentNameLbl;
        private System.Windows.Forms.Label ParentNameLabel;
        private System.Windows.Forms.Label ParentContactLbl;
        private System.Windows.Forms.Label ParentContactLabel;
        private System.Windows.Forms.Label HobbiesLbl;
        private System.Windows.Forms.Label HobbiesLabel;
        private System.Windows.Forms.Label NicknameLbl;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Button EditUpdateBtn;
    }
}