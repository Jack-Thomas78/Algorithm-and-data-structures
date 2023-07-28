using System;


namespace Week4TaskA
{
    class Program
    {
        static public void InsertSortGen<T>(T[] x) where T : IComparable
        {
            for(int i = 1; i < x.Length; i++)
            {
                T value = x[i];
                int j = i;

                for (; j > 0 && value.CompareTo(x[j - 1]) < 0; j--)  
                {
                    x[j] = x[j - 1];
                }
                x[j] = value;
            }
        }
        static void Main(string[] args)
        {
            int[] id = {1023,6034,3083,4343,8553};
            string[] name = {"Ali","Bob","Carl","Dave","Eli" };
            Student[] stuList = new Student[5];

            int[] sortint = new int[15];
            Random rnd = new Random();
            

            for (int i = 0; i < sortint.Length; i++)
            {
                int x = rnd.Next(1, 101);
                sortint[i] = x;
            }

            for(int i = 0; i<stuList.Length;i++)
            {
                stuList[i] = new Student(id[i], name[i]);
            }

            Console.WriteLine("Unsorted list:");

            foreach( Student n in stuList)
            {
                Console.WriteLine(n);
            }

            InsertSortGen(stuList);

            Console.WriteLine("Sorted list:");

            foreach (Student n in stuList)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Unsorted int list:");

            foreach (int n in sortint)
            {
                Console.WriteLine(n);
            }

            InsertSortGen(sortint);

            Console.WriteLine("Sorted int list:");

            foreach (int n in sortint)
            {
                Console.WriteLine(n);
            }
        }
    }
}
