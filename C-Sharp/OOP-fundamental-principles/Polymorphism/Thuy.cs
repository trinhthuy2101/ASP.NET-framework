using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Thuy:Person
    {
        public override void Eat()
        {
            Console.WriteLine("Thuy is eating\n");
        }
        public override void Learn()
        {
            Console.WriteLine("Thuy is learning\n");
        }
        public override void Sleep()
        {
            Console.WriteLine("Thuy is sleeping\n");
        }
    }
}
