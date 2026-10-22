using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
           
            InitializeComponent();
            AttachTextboxEvents(this);
            // Initialize things here
            panel1.BackColor = Color.FromArgb(140, 255, 255, 255);



        }

        private bool ValidateTextBoxes(Control parent)
        {
            bool foundInvalid = false;

            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                {
                    // Check empty OR already showing required message
                    if (string.IsNullOrWhiteSpace(tb.Text) || tb.Text == "This field is required!")
                    {
                        tb.Text = "This field is required!";
                        tb.ForeColor = Color.Red;
                        foundInvalid = true;
                    }
                }

                if (c.HasChildren)
                    foundInvalid = ValidateTextBoxes(c) || foundInvalid;
            }
            return foundInvalid;
        }





        private void Form2_Load(object sender, EventArgs e)
        {

            panel1.BackColor = Color.FromArgb(140, 255, 255, 255);
            panel3.Visible = false;  // hide panel3 initially
            panel4.Visible = true;   // optional (if you want panel4 visible first)
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;   // show panel3
            panel4.Visible = false;  // hide panel4
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool hasEmpty = ValidateTextBoxes(panel4);

            if (!hasEmpty)
            {
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
                this.Hide();
            }
        }
        private void AttachTextboxEvents(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.Enter += ResetTextbox; // runs when user clicks the textbox
                }

                if (c.HasChildren)
                    AttachTextboxEvents(c);
            }
        }
        private void ResetTextbox(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb.Text == "This field is required!" && tb.ForeColor == Color.Red)
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;   // normal color
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=loginsample; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            string username = textBox6.Text.ToString();
            string Email = textBox3.Text.ToString();
            string password = textBox5.Text.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("No empty fields allowed");
            }
            else
            {
                MySqlCommand mySqlCommand = new MySqlCommand("selct * from users", mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                MySqlDataReader reader = mySqlDataReader;
                while (reader.Read())
                {
                    if (username.Equals(reader.GetString("Username")) && Email.Equals(reader.GetString("Email")) && password.Equals(reader.GetString("Password"))) ;
                    {
                        MessageBox.Show("Login Success");
                    }
                    
                   

                    }
                }

            




                bool hasEmpty = ValidateTextBoxes(panel3); // ✅ ONLY register panel

            if (!hasEmpty)
            {
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If checkbox is checked, show the password
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}


