namespace DCMS
{
    partial class Dashboard
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
            newcompbutton = new Button();
            vcbutton = new Button();
            ecbutton = new Button();
            EXITbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 31);
            label1.Name = "label1";
            label1.Size = new Size(871, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Digital Complain Management Syatem";
            // 
            // newcompbutton
            // 
            newcompbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newcompbutton.Location = new Point(231, 156);
            newcompbutton.Name = "newcompbutton";
            newcompbutton.Size = new Size(218, 68);
            newcompbutton.TabIndex = 1;
            newcompbutton.Text = "New Complain";
            newcompbutton.UseVisualStyleBackColor = true;
            newcompbutton.Click += newcompbutton_Click;
            // 
            // vcbutton
            // 
            vcbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vcbutton.Location = new Point(569, 156);
            vcbutton.Name = "vcbutton";
            vcbutton.Size = new Size(303, 68);
            vcbutton.TabIndex = 2;
            vcbutton.Text = "View Past Complain";
            vcbutton.UseVisualStyleBackColor = true;
            vcbutton.Click += vcbutton_Click;
            // 
            // ecbutton
            // 
            ecbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ecbutton.Location = new Point(231, 270);
            ecbutton.Name = "ecbutton";
            ecbutton.Size = new Size(218, 68);
            ecbutton.TabIndex = 3;
            ecbutton.Text = "Edit Complain";
            ecbutton.UseVisualStyleBackColor = true;
            ecbutton.Click += ecbutton_Click;
            // 
            // EXITbutton
            // 
            EXITbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EXITbutton.Location = new Point(569, 270);
            EXITbutton.Name = "EXITbutton";
            EXITbutton.Size = new Size(303, 68);
            EXITbutton.TabIndex = 4;
            EXITbutton.Text = "Exit Application";
            EXITbutton.UseVisualStyleBackColor = true;
            EXITbutton.Click += EXITbutton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 512);
            Controls.Add(EXITbutton);
            Controls.Add(ecbutton);
            Controls.Add(vcbutton);
            Controls.Add(newcompbutton);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private Button newcompbutton;
        private Button vcbutton;
        private Button ecbutton;
        private Button EXITbutton;
    }
}