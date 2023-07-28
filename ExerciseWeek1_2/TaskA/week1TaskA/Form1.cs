using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week1TaskA
{
    public partial class Form1 : Form
    {
        private JobQueue joblist;
        public Form1()
        {
            joblist = new JobQueue();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Task task = new Task(taskinput.Text);
            joblist.Enqueue(task);
            taskoutput.Text = joblist.Peek().ToString();
            taskinput.Text = "";
            countlabel.Text = "Count: " + joblist.Contents();
        }

        private void complete_Click(object sender, EventArgs e)
        {
            joblist.Dequeue();
            countlabel.Text = "Count: " + joblist.Contents();
            taskoutput.Text = ""+ joblist.Peek().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
