using System;

namespace MyLibrary
{
    public sealed class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        protected internal int _age { get; set; }
        private protected string _fatherName { get; set; }


        public void PrintFatherName()
        {
            Console.WriteLine(_fatherName);
        }

    }
}
