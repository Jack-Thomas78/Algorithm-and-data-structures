using System;
using System.Collections.Generic;
using System.Text;

namespace Week4TaskB
{
    class Activity : IComparable
    {
        private string desc;
        private float start;
        private float fin;
        private float duration;

        public Activity(string desc, float start, float fin)
        {
            this.desc = desc;
            this.start = start;
            this.fin = fin;
            this.duration = fin - start;
        }

        static public void InsertSort(Activity[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != null)
                {
                    Activity value = x[i];
                    int j = i;

                    for (; j > 0 && value.CompareTo(x[j - 1]) < 0; j--)
                    {
                        x[j] = x[j - 1];
                    }
                    x[j] = value;
                }
            }
        }
        public string Desc
        {
            set { this.desc = value; }
            get { return desc; }
        }

        public float Start
        {
            set { this.start = value; }
            get { return start; }
        }

        public float Fin
        {
            set { this.fin = value; }
            get { return fin; }
        }

        public override string ToString()
        {
            return "[Desc: "+ desc +" start time: " +  start + " end time: " + fin + " Duration: " + duration + " ]";
        }

        public int CompareTo(object obj)
        {
            Activity other = (Activity)obj;
            return fin.CompareTo(other.fin);
        }
    }
}
