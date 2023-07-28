using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5TaskB
{
    public partial class Form1 : Form
    {
        Graph<string> names;
        public Form1()
        {
            InitializeComponent();
            names = new Graph<string>();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            if(name.Text != "")
            {
                names.AddNode(name.Text);
                name.Text = "";
                countL.Text = "Count: " + names.NodeCount();
            }
        }

        private void addEdgeB_Click(object sender, EventArgs e)
        {
            if (names.ContainsNode(names.GetNodeById(xNode.Text)) == true && names.ContainsNode(names.GetNodeById(yNode.Text)) == true)
            {
                names.AddEdge(xNode.Text, yNode.Text);
                xNode.Text = "";
                yNode.Text = "";
            }

        }

        private void displayB_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (name.Text != "")
            {
                List<string> nameList = new List<string>();
                names.BreadthFirstTraverse(name.Text, ref nameList);

                foreach (string n in nameList)
                {
                    listBox1.Items.Add(n);
                }
            }
            listBox1.Items[0].BackColor = Color.Green;
        }

        private void removeB_Click(object sender, EventArgs e)
        {
            if (name.Text != "")
            {
                names.RemoveNode(name.Text);
                countL.Text = "Count: " + names.NodeCount();
                name.Text = "";
            }
        }
    }
}
