namespace WinFormsApp3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button4 = new Button();
            panel3 = new Panel();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button5 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(496, 72);
            button4.Name = "button4";
            button4.Size = new Size(110, 29);
            button4.TabIndex = 11;
            button4.Text = "BLOG";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(704, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 49);
            panel3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(223, 14);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 4;
            label5.Text = "Search...";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(331, 72);
            button3.Name = "button3";
            button3.Size = new Size(149, 29);
            button3.TabIndex = 12;
            button3.Text = "CONTACT US";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(165, 72);
            button2.Name = "button2";
            button2.Size = new Size(147, 29);
            button2.TabIndex = 13;
            button2.Text = "DESTINATION";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(85, 14);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 4;
            label1.Text = "Discover";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSeaGreen;
            panel5.Controls.Add(label1);
            panel5.Location = new Point(1017, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 49);
            panel5.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 44);
            panel2.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(49, 72);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 14;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(290, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 653);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(456, 98);
            panel4.Name = "panel4";
            panel4.Size = new Size(449, 431);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 247);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "Message";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 247);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 76);
            textBox3.TabIndex = 10;
            textBox3.UseSystemPasswordChar = true;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 119);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(134, 367);
            button5.Name = "button5";
            button5.Size = new Size(183, 29);
            button5.TabIndex = 9;
            button5.Text = "SUBMIT";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 184);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 5;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 39);
            label2.Name = "label2";
            label2.Size = new Size(162, 34);
            label2.TabIndex = 0;
            label2.Text = "Contact Us";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSeaGreen;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(0, 127);
            panel6.Name = "panel6";
            panel6.Size = new Size(299, 657);
            panel6.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(90, 345);
            label9.Name = "label9";
            label9.Size = new Size(125, 18);
            label9.TabIndex = 4;
            label9.Text = "ExploreSriLanka";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(90, 275);
            label8.Name = "label8";
            label8.Size = new Size(105, 18);
            label8.TabIndex = 3;
            label8.Text = "+94774578932";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(90, 210);
            label7.Name = "label7";
            label7.Size = new Size(174, 18);
            label7.TabIndex = 1;
            label7.Text = "Akurassa Road,Matara";
            // 
            // panel9
            // 
            panel9.BackgroundImage = (Image)resources.GetObject("panel9.BackgroundImage");
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.Location = new Point(26, 327);
            panel9.Name = "panel9";
            panel9.Size = new Size(46, 47);
            panel9.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Location = new Point(26, 255);
            panel8.Name = "panel8";
            panel8.Size = new Size(46, 47);
            panel8.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(26, 197);
            panel7.Name = "panel7";
            panel7.Size = new Size(46, 40);
            panel7.TabIndex = 1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 770);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(button4);
            Controls.Add(panel3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Panel panel3;
        private Label label5;
        private Button button3;
        private Button button2;
        private Label label1;
        private Panel panel5;
        private Panel panel2;
        private Button button1;
        private Panel panel1;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Button button5;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox3;
        private Panel panel6;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}