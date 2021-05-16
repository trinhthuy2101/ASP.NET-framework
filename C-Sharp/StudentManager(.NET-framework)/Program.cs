using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Controller;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerCenter _controllerCenter = new ControllerCenter();
           _controllerCenter.InfoManagerment();
        }
    }
}
