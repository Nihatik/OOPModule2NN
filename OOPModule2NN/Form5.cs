using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPModule2NN
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = !button2.Visible;
            button3.Visible = !button3.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Enabled = !button4.Enabled;
            button5.Enabled = !button5.Enabled;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.BackColor = button4.BackColor == Color.Red ? Color.Green : Color.Red;
            button5.BackColor = button5.BackColor == Color.Blue ? Color.Yellow : Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Size = new Size(button5.Size.Width + 20, button5.Size.Height + 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Text = "Изменено!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button4.BackColor = DefaultBackColor;
            button5.BackColor = DefaultBackColor;
            button5.Size = new Size(100, 40);
            button6.Text = "Button 6";
        }
    }
}
