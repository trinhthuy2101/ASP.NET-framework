using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Person
    {
        private string _name;
        private int _age;
        private double _weight;
        private double _height;

        public Person()
        {
            _name = "Nguyen Van A";
            _age = 20;
            _weight = 60;
            _height = 1.78;
        }
        public void BMI()
        {
            Console.WriteLine("BMI index:");
            Console.WriteLine(_weight / (_height * _height));
        }
    }
}
