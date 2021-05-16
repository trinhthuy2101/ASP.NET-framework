using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Controller;
using StudentManager.Model;

namespace StudentManager.View
{
    class ViewInfo
    {
        CStudent s=new CStudent();
        public void MessageForm(string action, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(action + ": " + msg);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue");
        }

        public string Show(CStudent student)
        {
            return Convert.ToString(student._id)+"\n"+student._name+"\n" + Convert.ToString(student._age)+"\n";
        }
        public string ShowStudents(DataContext dataContext)
        {
            int i = 0;
            int count = dataContext.UniversityModel._departmentModels[0]._classes[0]._students.Count();
            if (count == 0) return "Student is empty\n";
            string buf="";
            while (i != count)
            {
                CStudent a = dataContext.UniversityModel._departmentModels[0]._classes[0]._students[i];
                buf+="Name: " + a._name + "\t" + "ID: " + a._id + "\t" + "Age: " + a._age + "\n";
                i++;
            }
            return buf;
        }
        public string GenerateInfoBoard()
        {
            List<string> actions = new List<string>()
            {
                "Add new",
                "Update",
                "Remove",
                ">Show",
                ">SAVE",
                ">Exit without saving"
            };
            int i = 1;
            string textInfoAll = string.Empty;
            foreach (var action in actions)
            {
                textInfoAll += string.Format("\n{0} -> {1}", i++, action);
            }
            return textInfoAll + "\n -------------------- \n";
        }
    }
}
