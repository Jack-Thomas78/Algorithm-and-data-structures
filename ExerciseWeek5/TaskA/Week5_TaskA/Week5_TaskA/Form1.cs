using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_TaskA
{
    public partial class Form1 : Form
    {
        Graph<int> n = new Graph<int>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (nodeInsert.Text != "")
            {
                n.AddNode(Convert.ToInt32(nodeInsert.Text));
                count.Text = "Node count: " + n.NodesCount();
                nodeInsert.Text = "";
            }
            else { }
        }

        private void add_Click(object sender, EventArgs e)
        {
            n.AddEdge(Convert.ToInt32(nodeX.Text), Convert.ToInt32(nodeY.Text));
            nodeX.Text = "";
            nodeY.Text = "";
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (n.IsAdj(n.GetNodeById(Convert.ToInt32(nodeAdjX.Text)), n.GetNodeById(Convert.ToInt32(nodeAdjY.Text)))== true)
            {
                adj.Text ="Node "+ nodeAdjX.Text +" is adjacent to " + nodeAdjY.Text;
            }
            else
            {
                adj.Text = "Nodes are not adjacent or do not exist";
            }
        }
    }
}
