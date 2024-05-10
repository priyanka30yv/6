using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApps1
{
    public partial class frmThread1 : Form
    {
        int ctr1;
        int ctr2;
        int ctr3;
        int ctr4;

        public frmThread1()
        {
            InitializeComponent();
        }
        void add()
        {
            for (ctr1 = 0; ctr1 < 10; ctr1++)
            {
                BackColor = Color.Teal;
                listBox1.Items.Add("counter1 :" + ctr1.ToString());
                Thread.Sleep(1000);
            }
        }
        void addagain()
        {
            for (ctr2 = 0; ctr2 < 10; ctr2++)
            {
                BackColor = Color.Black;
                listBox1.Items.Add("counter2 :" + ctr2.ToString());
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(add);
            t1.Start();
            Thread t2 = new Thread(addagain);
            t2.Start();
            MessageBox.Show("hello");
            Thread.Sleep(5000);
            t1.Join();
            t2.Join();

            listBox1.Items.Add("india joined");
            listBox1.Items.Add("new zealand joined");
            listBox1.Items.Add("uae joined");
            listBox1.Items.Add("usa joined");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t3 = new Thread(Greysoft);
            t3.Start();
            Thread.Sleep(5000);
            t3.Join();
            for (ctr3 = 0; ctr3 < 10; ctr3++)
            {
                BackColor = Color.Pink;
                listBox2.Items.Add("counter3 :" + ctr3.ToString());
                Thread.Sleep(5000);

            }
        }
        public void Greysoft()
        {
            for (ctr4 = 0; ctr4 < 10; ctr4++)
            {
                BackColor = Color.Cyan;
                listBox2.Items.Add("counter4 :" + ctr4.ToString());
                Thread.Sleep(1000);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task t1 = new Task(addData);
            t1.Start();
            Task t2 = new Task(addColor);
            t2.Start();

        }
        public void addData()
        {
            listBox3.Items.Add("india");
            Thread.Sleep(1000);
            listBox3.Items.Add("china");
        }
        public void addColor()
        {
            listBox3.Items.Add("red");
            Thread.Sleep(1000);
            listBox3.Items.Add("blue");
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Task<int> t1 = AddData(12);
                int ans = await t1;
            listBox4.Items.Add(ans);

        }
        public async Task<int> AddData(int x)
        {
            int ctr = 0;
            await Task.Run(() => { ctr = x * x; });
            return ctr;
        }

    }
}
