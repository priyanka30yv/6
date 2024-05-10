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
    public partial class frmException1 : Form
    {
        int num1;
        int num2;
        public frmException1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
           num2 = Convert.ToInt32(textBox2.Text);
           
                int ans = num1 / num2;
                MessageBox.Show("the answer is " + ans.ToString());
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("cannot divide by zero" +ex.Message);
                num2 = 2;

            }
            catch(FormatException ex)
            {
                MessageBox.Show("non numeric data"+ex.Message);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            catch(Exception ex) {
                MessageBox.Show("we are facing the problem" + ex.Message);
            }
        }
    }
}
