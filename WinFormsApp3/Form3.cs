using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            AttachPanelHover(this);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void AttachPanelHover(Control parent)
        {
            // List of panels to stay stationary
            string[] stationaryPanels = { "panel2", "panel3", "panel5", "panel9" };

            foreach (Control c in parent.Controls)
            {
                if (c is Panel p && !stationaryPanels.Contains(p.Name)) // skip stationary panels
                {
                    p.MouseEnter += Panel_MouseEnter;
                    p.MouseLeave += Panel_MouseLeave;
                }

                if (c.HasChildren)
                    AttachPanelHover(c);
            }
        }


        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p != null)
                p.BackColor = Color.LightGray; // or any hover color
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p != null)
                p.BackColor = SystemColors.Control; // or original color
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
