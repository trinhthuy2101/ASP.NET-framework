using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App_Students
{
    class CDepartment:CUniversity
    {
        protected string _departmentName;
        public virtual void InputDepartmentName()
        {
            Console.WriteLine("Input Depaertment: ");
            _departmentName = Console.ReadLine();
        }
        public void OuputDepartmentName()
        {
            Console.WriteLine("Department: ");
            Console.WriteLine(_departmentName);
        }
    }
}
