using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITStep_WinForm2_dz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что Вы так думаете!");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, ClientSize.Width - button2.Width);
            int y = random.Next(0, ClientSize.Height - button2.Height);

            button2.Location = new Point(x, y);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Location = new Point(50, 50);
        }
    }
}
