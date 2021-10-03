using MyLibrary;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region static members
            //int[] nums = {5,2,1,3,6 };
            //Array.Sort(nums);

            //foreach (int item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //Worker.SumInArr();
            //Worker w1 = new Worker("Mamed","Alisoy");
            //Worker w2 = new Worker("Mamed", "Alisoy");
            //Worker w3 = new Worker("Mamed", "Alisoy");
            //Worker w4 = new Worker("Mamed", "Alisoy");

            //Console.WriteLine($"{w1.Id} {Worker.Count}");
            //Console.WriteLine($"{w2.Id} {Worker.Count}");
            //Console.WriteLine($"{w3.Id} {Worker.Count}");
            //Console.WriteLine($"{w4.Id} {Worker.Count}");

            //Console.WriteLine(WorkersAreSame(w1,w1));
            //Console.WriteLine(WorkersAreSame(w3,w4));
            #endregion

            #region static class
            //Console.WriteLine(Calculator.Sum(2,4));
            #endregion
        }

        static bool WorkersAreSame(Worker w1, Worker w2)
        {
            if (w1.Name != w2.Name)
            {
                return false;
            }

            if (w1.Surname != w2.Surname)
            {
                return false;
            }

            if (w1.Id != w2.Id)
            {
                return false;
            }

            return true;
        }
    }



    class Worker
    {
        public int Id;
        public string Name;
        public string Surname;

        public static int Count = 0;
        
        //Static ctor - parameterless, called only once, cant be called
        static Worker()
        {
        }

        public Worker()
        {
            Count++;
            Id = Count;
        }

        public Worker(string Name , string Surname):this()
        {
            this.Name = Name;
            this.Surname = Surname;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Count}");
        }

        public static int SumInArr(params int[] arr)
        {
            int result = 0;
            foreach (int item in arr)
            {
                result += item;
            }
            return result;
        }

        //public int SumInArr(params int[] arr)
        //{
        //    int result = 0;
        //    foreach (int item in arr)
        //    {
        //        result += item;
        //    }
        //    return result;
        //}

    }

}
