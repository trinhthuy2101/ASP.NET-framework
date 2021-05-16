using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App_Students
{
    class CUniversity
    {
        protected string _universityName;
        public virtual void InputUniName()
        {
            Console.WriteLine("Input University: ");
            _universityName = Console.ReadLine();
        }
        public void OuputUniName()
        {
            Console.WriteLine("University: ");
            Console.WriteLine(_universityName);
        }
    }
}
