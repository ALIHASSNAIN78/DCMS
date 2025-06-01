namespace DCMS
{
    partial class Register
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
            label4 = new Label();
            label5 = new Label();
            nametextBox = new TextBox();
            phonetextBox = new TextBox();
            etextBox = new TextBox();
            passwdtextBox = new TextBox();
            regbutton = new Button();
            closebutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 47);
            label1.Name = "label1";
            label1.Size = new Size(425, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(211, 155);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(211, 215);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 1;
            label3.Text = "Phone no:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(211, 271);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(211, 329);
            label5.Name = "label5";
            label5.Size = new Size(138, 32);
            label5.TabIndex = 1;
            label5.Text = "Password:";
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(394, 160);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(297, 27);
            nametextBox.TabIndex = 1;
            // 
            // phonetextBox
            // 
            phonetextBox.Location = new Point(394, 221);
            phonetextBox.Name = "phonetextBox";
            phonetextBox.Size = new Size(297, 27);
            phonetextBox.TabIndex = 2;
            phonetextBox.TextChanged += textBox1_TextChanged;
            // 
            // etextBox
            // 
            etextBox.Location = new Point(394, 277);
            etextBox.Name = "etextBox";
            etextBox.Size = new Size(297, 27);
            etextBox.TabIndex = 3;
            // 
            // passwdtextBox
            // 
            passwdtextBox.Location = new Point(394, 335);
            passwdtextBox.Name = "passwdtextBox";
            passwdtextBox.Size = new Size(297, 27);
            passwdtextBox.TabIndex = 4;
            // 
            // regbutton
            // 
            regbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regbutton.Location = new Point(212, 406);
            regbutton.Name = "regbutton";
            regbutton.Size = new Size(183, 59);
            regbutton.TabIndex = 5;
            regbutton.Text = "Register";
            regbutton.UseVisualStyleBackColor = true;
            regbutton.Click += regbutton_Click;
            // 
            // closebutton
            // 
            closebutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebutton.Location = new Point(508, 406);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(183, 59);
            closebutton.TabIndex = 6;
            closebutton.Text = "Close";
            closebutton.UseVisualStyleBackColor = true;
            closebutton.Click += closebutton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 614);
            Controls.Add(closebutton);
            Controls.Add(regbutton);
            Controls.Add(passwdtextBox);
            Controls.Add(etextBox);
            Controls.Add(phonetextBox);
            Controls.Add(nametextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nametextBox;
        private TextBox phonetextBox;
        private TextBox etextBox;
        private TextBox passwdtextBox;
        private Button regbutton;
        private Button closebutton;
    }
}