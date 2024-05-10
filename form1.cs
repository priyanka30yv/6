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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnsms_Click(object sender, EventArgs e)
        {
            sms obj = new sms();
            obj.from = txtfrom.Text;
            obj.to = txtto.Text;
            lblsms.Text = obj.from + "send a message to " + obj.to;
        }

    }
    class sms
    {
        public string from;
        public string to;
    }
}
