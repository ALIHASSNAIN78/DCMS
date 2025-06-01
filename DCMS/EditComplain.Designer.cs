namespace DCMS
{
    partial class EditComplain
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
            editbutton = new Button();
            delbutton = new Button();
            clsbutton = new Button();
            dataGridViewedit = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewedit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 65);
            label1.Name = "label1";
            label1.Size = new Size(263, 46);
            label1.TabIndex = 0;
            label1.Text = "Edit Complain";
            // 
            // editbutton
            // 
            editbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editbutton.Location = new Point(892, 65);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(161, 54);
            editbutton.TabIndex = 1;
            editbutton.Text = "Edit";
            editbutton.UseVisualStyleBackColor = true;
            editbutton.Click += editbutton_Click;
            // 
            // delbutton
            // 
            delbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delbutton.Location = new Point(1090, 65);
            delbutton.Name = "delbutton";
            delbutton.Size = new Size(161, 54);
            delbutton.TabIndex = 2;
            delbutton.Text = "Delete";
            delbutton.UseVisualStyleBackColor = true;
            delbutton.Click += delbutton_Click;
            // 
            // clsbutton
            // 
            clsbutton.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clsbutton.Location = new Point(1299, 65);
            clsbutton.Name = "clsbutton";
            clsbutton.Size = new Size(161, 54);
            clsbutton.TabIndex = 3;
            clsbutton.Text = "Close";
            clsbutton.UseVisualStyleBackColor = true;
            clsbutton.Click += clsbutton_Click;
            // 
            // dataGridViewedit
            // 
            dataGridViewedit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewedit.Location = new Point(23, 155);
            dataGridViewedit.Name = "dataGridViewedit";
            dataGridViewedit.RowHeadersWidth = 51;
            dataGridViewedit.Size = new Size(1437, 551);
            dataGridViewedit.TabIndex = 4;
            // 
            // EditComplain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 792);
            Controls.Add(dataGridViewedit);
            Controls.Add(clsbutton);
            Controls.Add(delbutton);
            Controls.Add(editbutton);
            Controls.Add(label1);
            Name = "EditComplain";
            Text = "EditComplain";
            Load += EditComplain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewedit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button editbutton;
        private Button delbutton;
        private Button clsbutton;
        private DataGridView dataGridViewedit;
    }
}