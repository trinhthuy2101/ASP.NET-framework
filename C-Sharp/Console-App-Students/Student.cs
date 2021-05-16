using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App_Students
{
    class CStudent:CClass
    {
        private int _id;
        private string _name;
        private int _age;
        public void Add()
        {
            Console.Write("Input ID: ");
            _id = int.Parse(Console.ReadLine());
            Console.Write("Input name: ");
            _name = Console.ReadLine(); 
            Console.Write("Input age: ");
            _age = int.Parse(Console.ReadLine());
        }
        public void Update()
        {
            Console.Write("Update ID: ");
            _id = int.Parse(Console.ReadLine());
            Console.Write("Update name: ");
            _name = Console.ReadLine();
            Console.Write("Update age: ");
            _age = int.Parse(Console.ReadLine());
        }
        public void Delete()
        {
        }
        public void Show()
        {
            Console.Write("ID: ");
            Console.WriteLine(_id);
            Console.Write("Name: ", _name);
            Console.WriteLine(_name);
            Console.Write("Age: ",_age);
            Console.WriteLine(_age);
        }
    }
}
