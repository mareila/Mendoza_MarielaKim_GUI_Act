
namespace Mendoza_Mariela_Act_GUI
{
    partial class LoginForm
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
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Bookman Old Style", 10.2F);
            UsernameLabel.Location = new Point(115, 82);
            UsernameLabel.Margin = new Padding(7, 0, 7, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(101, 21);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username:";
            UsernameLabel.Click += this.UsernameLabel_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Bookman Old Style", 10.2F);
            PasswordLabel.Location = new Point(121, 143);
            PasswordLabel.Margin = new Padding(7, 0, 7, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(95, 21);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(220, 76);
            UsernameTextBox.Margin = new Padding(7, 4, 7, 4);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(364, 27);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(220, 140);
            PasswordTextBox.Margin = new Padding(7, 4, 7, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(364, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.Info;
            LoginBtn.Font = new Font("Bookman Old Style", 10.2F);
            LoginBtn.Location = new Point(307, 203);
            LoginBtn.Margin = new Padding(7, 4, 7, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(139, 38);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(704, 340);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Font = new Font("Bookman Old Style", 10.2F);
            Margin = new Padding(7, 4, 7, 4);
            Name = "LoginForm";
            Text = "Login Page";
            Load += this.LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginBtn;

        public EventHandler LoginForm_Load { get; private set; }
    }
}