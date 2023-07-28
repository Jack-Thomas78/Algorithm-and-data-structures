using System;
using System.Collections.Generic;
using System.Text;

namespace week1TaskA
{
    class Task
    {
        private string desc;

        public Task(string desc)
        {
            this.desc = desc;
        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        public override string ToString()
        {
            return desc;
        }
    }
}
