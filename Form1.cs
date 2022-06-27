using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Приколюха
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int x = 0, y = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            button1.Text = "Осталось" + (4 - i) + "раза";
            Random random = new Random();
           
            x = random.Next(30, 230);
            y = random.Next(30, 190);
            button1.Location = new System.Drawing.Point(x, y);

            if (i > 3)
            {
                button1.Visible = false;
                pictureBox1.Visible = true;
                label1.Visible = true;
            }
        }
    }
}
