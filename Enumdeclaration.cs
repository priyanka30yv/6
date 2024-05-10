using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApps1
{
    public partial class Enumdeclaration : Form
    {
        public Enumdeclaration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Volume.Low.ToString());
            int ans = (int)Volume.Low;
            MessageBox.Show(ans.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int choice = 20;
            switch (choice) {
                case 30:
                    MessageBox.Show("you are a gold medalist");
                    break;
                case (int)Medal.Silver:
                    MessageBox.Show("silver medal");
                    break;
                case 10:
                    MessageBox.Show("at least won a bronze medal");
                    break;
                default:
                    MessageBox.Show("learn gold enum and thing");
                    break;
            }

        }
    }
}
