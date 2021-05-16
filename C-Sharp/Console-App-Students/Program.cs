using System;
using System.Collections.Generic;

namespace Console_App_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            CStudent a = new CStudent();
            List<CStudent> MyList = new List<CStudent>();
            a.Add();
            MyList.Add(a);
            MyList[0].Show();
            MyList[0].Update();
            MyList[0].Show();
        }
    }
}
