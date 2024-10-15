using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPModule2NN
{
    public partial class InputForm : Form
    {
        public bool CheckBox1IsChecked => checkBox1.Checked;
        public bool CheckBox2IsChecked => checkBox2.Checked;
        public int sideA;
        public int sideB;
        public int sideC;
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int a) &&
            int.TryParse(textBox2.Text, out int b) &&
            int.TryParse(textBox3.Text, out int c))
            {
                sideA = a;
                sideB = b;
                sideC = c;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите корректные длины сторон!");
            }
        }
    }
}
