using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPModule2NN
{
    public partial class Form1 : Form
    {
        private bool isTriangle = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isTriangle)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.Region = null; 
                this.ClientSize = new Size(800, 450);
                button1.Text = "Треугольник";
            }
            else
            {
                GraphicsPath path = new GraphicsPath();
                path.AddPolygon(new Point[]
                {
                    new Point(400, 0), 
                    new Point(800, 450),
                    new Point(0, 450) 
                });
                this.Region = new Region(path);
                this.FormBorderStyle = FormBorderStyle.None;
                this.ClientSize = new Size(800, 450);
                button1.Text = "Квадрат";
            }
            isTriangle = !isTriangle;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 50, this.Location.Y + 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form3 form = new Form3();
            form.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {

            Upr4 form = new Upr4();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Upr8 form = new Upr8();
            form.ShowDialog();
        }

    }
}
