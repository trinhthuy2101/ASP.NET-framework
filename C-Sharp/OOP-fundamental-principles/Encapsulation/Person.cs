using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Person
    {
        private string _name;
        private int _age;
        public void Eat()
        {
            Console.WriteLine("This person is eating\n");
        }
        public void Learn()
        {
            Console.WriteLine("This person is learning\n");
        }
        public void Sleep()
        {
            Console.WriteLine("This person is sleeping\n");
        }
       
    }
}