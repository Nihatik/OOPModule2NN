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
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        public void SetTextBoxText1(string text)
        {
            textBox1.Text = text;
        }

        public void SetTextBoxText2(string text)
        {
            textBox2.Text = text;
        }
    }
}
