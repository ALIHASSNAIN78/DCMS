namespace DCMS
{
    partial class NewComplain
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
            label6 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            idtextBox = new TextBox();
            catcomboBox = new ComboBox();
            pricomboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            subtextBox = new TextBox();
            destextBox = new TextBox();
            label8 = new Label();
            addresstextBox = new TextBox();
            submitbutton = new Button();
            clbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 31);
            label1.Name = "label1";
            label1.Size = new Size(268, 46);
            label1.TabIndex = 0;
            label1.Text = "New Complain";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 111);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 1;
            label2.Text = "UserID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(532, 106);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 262);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 3;
            label4.Text = "Subject:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 179);
            label5.Name = "label5";
            label5.Size = new Size(118, 32);
            label5.TabIndex = 4;
            label5.Text = "Priority:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(532, 194);
            label6.Name = "label6";
            label6.Size = new Size(145, 32);
            label6.TabIndex = 5;
            label6.Text = "Date/Time:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(61, 543);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(295, 36);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Terms and Comdition";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(61, 344);
            label7.Name = "label7";
            label7.Size = new Size(161, 32);
            label7.TabIndex = 3;
            label7.Text = "Description:";
            // 
            // idtextBox
            // 
            idtextBox.Location = new Point(240, 111);
            idtextBox.Name = "idtextBox";
            idtextBox.Size = new Size(198, 27);
            idtextBox.TabIndex = 1;
            // 
            // catcomboBox
            // 
            catcomboBox.FormattingEnabled = true;
            catcomboBox.Items.AddRange(new object[] { "Health", "Educatrion", "Municipal Services", "Land Revenue", "Corruption", "Law and Oder", "Transport", "Human Right Violation", "Investment", "NADRA", "FBR", "Captial Development Authority(CDA)", "Banking", "Airports", "Railways", "NHA", "Pakistan Post", "Pakistan Engineering Council", "PTCL", "Motorways", "NTC", "OGRA", "Ports and Shippings" });
            catcomboBox.Location = new Point(703, 110);
            catcomboBox.Name = "catcomboBox";
            catcomboBox.Size = new Size(271, 28);
            catcomboBox.TabIndex = 2;
            // 
            // pricomboBox
            // 
            pricomboBox.FormattingEnabled = true;
            pricomboBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            pricomboBox.Location = new Point(240, 183);
            pricomboBox.Name = "pricomboBox";
            pricomboBox.Size = new Size(198, 28);
            pricomboBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(703, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // subtextBox
            // 
            subtextBox.Location = new Point(240, 268);
            subtextBox.Name = "subtextBox";
            subtextBox.Size = new Size(201, 27);
            subtextBox.TabIndex = 5;
            // 
            // destextBox
            // 
            destextBox.Location = new Point(240, 350);
            destextBox.Multiline = true;
            destextBox.Name = "destextBox";
            destextBox.Size = new Size(734, 93);
            destextBox.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(532, 268);
            label8.Name = "label8";
            label8.Size = new Size(120, 32);
            label8.TabIndex = 5;
            label8.Text = "Address:";
            // 
            // addresstextBox
            // 
            addresstextBox.Location = new Point(703, 274);
            addresstextBox.Name = "addresstextBox";
            addresstextBox.Size = new Size(271, 27);
            addresstextBox.TabIndex = 6;
            // 
            // submitbutton
            // 
            submitbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitbutton.Location = new Point(71, 606);
            submitbutton.Name = "submitbutton";
            submitbutton.Size = new Size(269, 71);
            submitbutton.TabIndex = 9;
            submitbutton.Text = "Submit Complain";
            submitbutton.UseVisualStyleBackColor = true;
            submitbutton.Click += submitbutton_Click;
            // 
            // clbutton
            // 
            clbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clbutton.Location = new Point(587, 606);
            clbutton.Name = "clbutton";
            clbutton.Size = new Size(269, 71);
            clbutton.TabIndex = 10;
            clbutton.Text = "Close";
            clbutton.UseVisualStyleBackColor = true;
            clbutton.Click += clbutton_Click;
            // 
            // NewComplain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 713);
            Controls.Add(clbutton);
            Controls.Add(submitbutton);
            Controls.Add(addresstextBox);
            Controls.Add(destextBox);
            Controls.Add(subtextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(pricomboBox);
            Controls.Add(catcomboBox);
            Controls.Add(idtextBox);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewComplain";
            Text = "NewComplain";
            Load += NewComplain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private Label label7;
        private TextBox idtextBox;
        private ComboBox catcomboBox;
        private ComboBox pricomboBox;
        private DateTimePicker dateTimePicker1;
        private TextBox subtextBox;
        private TextBox destextBox;
        private Label label8;
        private TextBox addresstextBox;
        private Button submitbutton;
        private Button clbutton;
    }
}