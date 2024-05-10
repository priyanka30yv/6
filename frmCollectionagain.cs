using System;
using System.Collections;
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
    public partial class frmCollectionagain : Form
    {
        Stack st;
        Queue q;
        public frmCollectionagain()
        {
            InitializeComponent();
        }

        private void frmCollectionagain_Load(object sender, EventArgs e)
        {
            st = new Stack();
            st.Push("priyanka");
            st.Push("roshani");
            st.Push("mayuri");
            st.Push("tejas");
            cbooriginal.Items.Add("lata");
            cbooriginal.Items.Add("beena");
            foreach (var x in st)
            {
                cbooriginal.Items.Add(x.ToString());
            }
            q = new Queue();
            q.Enqueue("heena");
            q.Enqueue("meena");
            q.Enqueue("leela");
            q.Enqueue("laila");
            cbooriginal.Items.Add("lata");
            cbooriginal.Items.Add("beena");
            foreach (var x1 in q)
            {
                cbooriginal.Items.Add(x1.ToString());
            }
        }

        private void btnstack_Click(object sender, EventArgs e)
        {
            string str = (string)st.Pop();
            listfinal.Items.Add(str);
           
        }
        private void btnqueue_Click(object sender, EventArgs e)
        {
            string str1 = (string)q.Dequeue();
            listfinal.Items.Add(str1);

        }
    }
}
