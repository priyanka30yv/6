using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Greysoft;
namespace WinApps1
{
    public partial class StructExamplePoint1 : Form
    {
        public StructExamplePoint1()
        {
            InitializeComponent();
        }

        private void StructExamplePoint1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point1 p1 = new Point1(); ;
            Point1 p2 = new Point1(12, 34); ;
          
            string msg1 = "point 1 x=" + p1.x.ToString();
            msg1 = msg1 + "and y=" + p1.y.ToString();
            string msg2 = "point 2 x=" + p2.x.ToString();
            msg2 = msg2 + "and y=" + p2.y.ToString();
            MessageBox.Show(msg1);
            MessageBox.Show(msg2);
        }
    }
}
