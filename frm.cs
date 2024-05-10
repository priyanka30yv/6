using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApps1
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        public void OneFunction(object sender, EventArgs e)
        {
          
            int num1 = 12;
            int num2 = 23;
            Button btn1 = (Button)sender;
            string choice = btnadd.Text;
            string finalmsg;
            int ans;
            choice = choice.ToLower();
            switch (choice)
            {
                case "addition":
                    ans = num1 + num2;
                    finalmsg = "the result of addition is " + ans.ToString();
                    break;

                case "substract":
                    ans = num1 - num2;
                    finalmsg = "the result of addition is " + ans.ToString();
                    break;


                case "multiplication":
                    ans = num1 * num2;
                    finalmsg = "the result of addition is " + ans.ToString();
                    break;

                case "divide":
                    ans = num1 / num2;
                    finalmsg = "the result of addition is " + ans.ToString();
                    break;
                case "modulo":
                    ans = num1 % num2;
                    finalmsg = "the result of addition is " + ans.ToString();
                    break;
                default:
                    finalmsg = "bo ans";
                    break;


            }
            MessageBox.Show(finalmsg);
        }
            private void frm_Load(object sender ,EventArgs e)
            {

            }

        }
    }

