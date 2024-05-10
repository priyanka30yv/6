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
    public partial class frmException2 : Form
    {
        public frmException2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salary=Convert.ToInt32(textBox1.Text);
            try
            {
                calsal(salary);
            }
            catch(SalException x)
            {
                MessageBox.Show(x.Message);
            }
            void calsal(int y){
                if (y <= 5000)
                    throw new SalException("salary cannot be less than 5000 ");
                MessageBox.Show("incremented salary " + (y + 1000));
            }
        }
        public class SalException : ApplicationException
        {
            public SalException(string msg) : base(msg) { }

        }
    }
}
