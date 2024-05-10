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
    public partial class frmCollection : Form
    {
        public frmCollection()
        {
            InitializeComponent();
        }

        private void btnarray_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add("india");
            list.Add(12);
            list.Add(true);
            list.Add("USA");
            foreach (var x in list)
            {
                MessageBox.Show(x.ToString());
            }
            int ctr = list.Count;
            lblans1.Text = "there are " + ctr + "elemet in collection";

        }

        private void btnstack_Click(object sender, EventArgs e)
        {
            Stack s = new Stack();
            s.Push("hi");
            s.Push("priyanka");
            s.Push(123);
            foreach (var x in s)
            {
                MessageBox.Show(x.ToString());
            }
            int ctr = s.Count;
            Console.WriteLine("the count is " + ctr + "element in collection");
            s.Pop();
            foreach (var x1 in s)
            {
                MessageBox.Show(x1.ToString());
            }
            int ctr1 = s.Count;
            Console.WriteLine("the count is " + ctr1 + "element in collection");
        }

        private void btnqueue_Click(object sender, EventArgs e)
        {
            Queue q = new Queue();
            q.Enqueue("hiii");
            q.Enqueue(12);
            foreach (var x in q)
            {
                MessageBox.Show(x.ToString());
            }
            int ctr = q.Count;
            Console.WriteLine("the count is " + ctr + "element in collection");

            q.Dequeue();

            foreach (var x in q)
            {
                MessageBox.Show(x.ToString());
            }
            int ctr1 = q.Count;
            Console.WriteLine("the count is " + ctr1 + "element in collection");

        }

        private void btnhash_Click(object sender, EventArgs e)
        {
            Hashtable h = new Hashtable();
            h.Add("1", "priyanka");
            h.Add("3", "priya");
            h.Add("pn", "panvel");
            if (h.ContainsValue("priyanka"))
                lblans1.Text = "priyanka found";
            if (h.ContainsKey("1"))
                lblans2.Text = "1 is present";
        }
    }
}
