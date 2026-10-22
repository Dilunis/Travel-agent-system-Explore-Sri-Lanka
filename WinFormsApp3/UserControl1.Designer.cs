namespace WinFormsApp3
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 290);
            label6.Name = "label6";
            label6.Size = new Size(76, 40);
            label6.TabIndex = 13;
            label6.Text = "Confirm\r\nPassword";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 27);
            textBox4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 174);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 27);
            textBox3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(91, 38);
            label7.Name = "label7";
            label7.Size = new Size(227, 38);
            label7.TabIndex = 6;
            label7.Text = "REGISTRATION";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(158, 231);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(230, 27);
            textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(158, 118);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(230, 27);
            textBox6.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(36, 234);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 3;
            label8.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(36, 121);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 2;
            label9.Text = "Username";
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(114, 355);
            button3.Name = "button3";
            button3.Size = new Size(183, 29);
            button3.TabIndex = 4;
            button3.Text = "REGISTER";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox5);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 431);
            panel1.TabIndex = 12;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(429, 435);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label8;
        private Label label9;
        private Button button3;
        private Panel panel1;
    }
}
