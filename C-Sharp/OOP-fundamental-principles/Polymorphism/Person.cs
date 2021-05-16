using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Person
    {
        protected string _name;
        protected int _age;
        public virtual void Eat()
        {
            Console.WriteLine("This person is eating\n");
        }
        public virtual void Learn()
        {
            Console.WriteLine("This person is learning\n");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("This person is sleeping\n");
        }
    }
}
