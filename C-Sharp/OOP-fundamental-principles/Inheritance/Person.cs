using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Person
    {
        protected string _name;
        protected int _age;
        protected double _weight;
        protected double _height;

        public Person()
        {
            _name = "Nguyen Van A";
            _age = 20;
            _weight = 70;
            _height = 1.88;
        }
        public void BMI()
        {
            Console.WriteLine("BMI index:");
            Console.WriteLine(_weight / (_height * _height));
        }
    }
}
