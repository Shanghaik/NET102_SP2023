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

namespace Demo_Event_Net103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "000";
            Button bt = new Button();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Start();  
            //Thread.Sleep(10000);
            //timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Random r = new Random();
            //while (Convert.ToInt32(label1.Text) < 1000)
            //{
            //    Thread.Sleep(500);
            //    label1.Text = r.Next(0, 1000).ToString();
            //}
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
