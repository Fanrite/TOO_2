using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOO_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aircraft Standart = new Aircraft("Транспортний", 10, 2);
            Standart.ShowInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aircraft UserCraft = new Aircraft();
            UserCraft.ShowInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
