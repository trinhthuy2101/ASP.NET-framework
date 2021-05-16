using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App_Students
{
    class CClass:CDepartment
    {
        protected string _className;
        public virtual void InputClassName()
        {
            Console.WriteLine("Class: ");
            _className=Console.ReadLine();
        }
        public void OuputClassName()
        {
            Console.WriteLine("Class: ");
            Console.WriteLine(_className);
        }
    }
}
