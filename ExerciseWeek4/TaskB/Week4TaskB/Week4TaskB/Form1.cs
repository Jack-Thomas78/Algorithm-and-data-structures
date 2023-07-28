using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4TaskB
{
    public partial class Form1 : Form
    {
        Activity[] activities;
        Activity[] OptimalAct;
        int z;
        
       
        public Form1()
        {
            activities = new Activity[10];
            OptimalAct = new Activity[10];
            z = 0;
            InitializeComponent();
            
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string s = start.Text;
            string f = fin.Text;
            float st = float.Parse(s);
            float fi = float.Parse(f);
            if (st > 24 || fi > 24)
            {
                start.Text = "";
                fin.Text = "";

            }
            else
            { 
                Activity activity = new Activity(desc.Text, st, fi);
                activities[z] = activity;
                Activities.Items.Add(activities[z].ToString());
                z++;
                start.Text = "";
                fin.Text = "";
                desc.Text = "";
            }
        }

        
        private void display_Click(object sender, EventArgs e)
        {
            Activities.Items.Clear();
            Array.Clear(activities,0,activities.Length);
        }

        private void sort_Click(object sender, EventArgs e)
        {
            Activities.Items.Clear();
            Activity.InsertSort(activities);
            OptimalAct[0] = activities[0];
            Activities.Items.Add(activities[0].ToString());
            int j = 0;
            for (int i = 1; i < activities.Length; i++)
            {
                if (activities[i] != null)
                {
                    if (OptimalAct[j].Fin <= activities[i].Start)
                    {
                        Activities.Items.Add(activities[i].ToString());
                        OptimalAct[++j] = activities[i];
                    }

                }
            }
            
        }
    }
}
