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
    public partial class frmException3 : Form
    {
        public frmException3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            try
            {
                MessageBox.Show(arr[6].ToString());
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show("showing 6th element at index 5" + arr[5].ToString());
            }
            finally
            {
                MessageBox.Show("finally block will always execute");
            }
        }
    }
}
