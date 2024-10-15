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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag != null)
            {
                switch (e.ClickedItem.Tag.ToString())
                {
                    case "NewDoc":
                        break;

                    case "Cascade":
                        this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                        break;

                    case "Title":
                        this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                        break;

                    default:
                        MessageBox.Show("Неизвестная команда");
                        break;
                }
            }
        }
    }
}
