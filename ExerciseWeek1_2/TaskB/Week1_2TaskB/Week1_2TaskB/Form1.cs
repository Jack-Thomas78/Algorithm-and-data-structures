using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_2TaskB
{
    public partial class Form1 : Form
    {
        LinkedListGen<JournalPapers> papers;

        public Form1()
        {
            InitializeComponent();
            papers = new LinkedListGen<JournalPapers>();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            JournalPapers paper = new JournalPapers(titleT.Text, yearT.Text, authorT.Text, journalT.Text);
            papers.AddItem(paper);
            listBox1.Items.Add(paper.ToString());
            papers.Sort();
            listBox1.Sorted = true;
            titleT.Text = "";
            yearT.Text = "";
            authorT.Text = "";
            journalT.Text = "";
        }

        private void removeB_Click(object sender, EventArgs e)
        {
            papers.Clear();
            listBox1.Items.Clear();
        }
    }
}
