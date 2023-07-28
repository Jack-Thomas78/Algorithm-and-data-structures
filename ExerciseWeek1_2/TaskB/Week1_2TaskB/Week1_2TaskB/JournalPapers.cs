using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_2TaskB
{
    class JournalPapers : IComparable
    {
        private string title;
        private string year;
        private string author;
        private string journalT;

        public JournalPapers(string t, string y, string a, string j)
        {
            this.title = t;
            this.year = y;
            this.author = a;
            this.journalT = j;
        }

        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }

        public string Year
        {
            get { return year; }
            set { this.year = value; }
        }
        public string Author
        {
            get { return author; }
            set { this.author = value; }
        }
        public string JournalT
        {
            get { return journalT; }
            set { this.journalT = value; }
        }

        public int CompareTo(object obj)
        {
            JournalPapers other = (JournalPapers)obj;
            return Author.CompareTo(other.Author);
        }

        public override string ToString()
        {
            return "[Author: " + author + " Title: " + title + " Journal: " + journalT + " Publication Year: " + year + " ]"; 
        }
    }
}
