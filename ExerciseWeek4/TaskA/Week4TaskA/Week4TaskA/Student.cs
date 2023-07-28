using System;
using System.Collections.Generic;
using System.Text;

namespace Week4TaskA
{
    class Student : IComparable
    {
        private int id;
        private string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        
        public override string ToString()
        {
            return id +""+ name;
        }

        public int CompareTo(Object obj)
        {
            Student other = (Student)obj;
            return id.CompareTo(other.id);
        }

    }
}
