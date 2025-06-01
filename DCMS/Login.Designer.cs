namespace DCMS
{
    partial class Login
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
            label3 = new Label();
            emailtextBox = new TextBox();
            passwordtextBox = new TextBox();
            loginbutton = new Button();
            registerbutton = new Button();
            exitbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 54);
            label1.Name = "label1";
            label1.Size = new Size(336, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome to DCMS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(196, 159);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(196, 230);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(368, 159);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(300, 27);
            emailtextBox.TabIndex = 1;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(368, 235);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(300, 27);
            passwordtextBox.TabIndex = 2;
            passwordtextBox.UseSystemPasswordChar = true;
            // 
            // loginbutton
            // 
            loginbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.Location = new Point(196, 318);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(174, 52);
            loginbutton.TabIndex = 3;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // registerbutton
            // 
            registerbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbutton.Location = new Point(494, 318);
            registerbutton.Name = "registerbutton";
            registerbutton.Size = new Size(174, 52);
            registerbutton.TabIndex = 4;
            registerbutton.Text = "Register";
            registerbutton.UseVisualStyleBackColor = true;
            registerbutton.Click += registerbutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbutton.Location = new Point(196, 403);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(472, 57);
            exitbutton.TabIndex = 5;
            exitbutton.Text = "Exit Application";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 544);
            Controls.Add(exitbutton);
            Controls.Add(registerbutton);
            Controls.Add(loginbutton);
            Controls.Add(passwordtextBox);
            Controls.Add(emailtextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emailtextBox;
        private TextBox passwordtextBox;
        private Button loginbutton;
        private Button registerbutton;
        private Button exitbutton;
    }
}