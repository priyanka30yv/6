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
    public partial class dynamicVar : Form
    {
        public dynamicVar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic ans = 12;
            MessageBox.Show(ans.ToString());
            ans = "training";
            MessageBox.Show(ans);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ans = 12;
            MessageBox.Show(ans.ToString());
           // ans = "training";--type is inferred at compile time 
           // MessageBox.Show(ans);
        }
    }
}
