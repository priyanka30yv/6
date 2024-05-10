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
    public partial class BoxingUnboxig : Form
    {
        public BoxingUnboxig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short a = 12;
            object x = (object)a;
            MessageBox.Show(x.ToString());
            int s1=sizeof(short);
            MessageBox.Show(s1.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.Int32 obj1 = 12;
            object obj2 = 14;
            int ans = (int)obj1 + (int)obj2;
            MessageBox.Show("the answer is" + ans.ToString());
        }
    }
}
