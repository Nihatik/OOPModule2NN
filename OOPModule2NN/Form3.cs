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
    public partial class Form3 : Form
    {
        private int a;
        private int b;
        private int c;
        private bool checkBox1IsChecked = false;
        private bool checkBox2IsChecked = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputForm form = new InputForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                a = form.sideA;
                b = form.sideB;
                c = form.sideC;
                checkBox1IsChecked = form.CheckBox1IsChecked;
                checkBox2IsChecked = form.CheckBox2IsChecked;
            }
            else
            {
                MessageBox.Show("Ввод был отменен.");
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CalcForm form = new CalcForm();

            
            if (checkBox1IsChecked)
            {
                int perimeter = a + b + c;
                form.SetTextBoxText1(perimeter.ToString());
            }
            else
            {
                form.SetTextBoxText1("Пусто");
            }
            if (checkBox2IsChecked)
            {
                double s = (a + b + c) / 2.0;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                form.SetTextBoxText2(area.ToString());
            }
            else
            {
                form.SetTextBoxText2("Пусто");
            }

            form.ShowDialog();
        }
    }
}
