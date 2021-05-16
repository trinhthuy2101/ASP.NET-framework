using StudentManager.Blo;
using StudentManager.Model;
using StudentManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Controller
{
    class ControllerCenter
    {
        string optionSelect = "";
        DataContext _dataContext;
        List<CUniversity> Universities { set; get; }
        ViewInfo _viewInfo = new ViewInfo();
        ObjectInOut _objectInOut = new ObjectInOut();
        StudentManagement _studentManagement = new StudentManagement();
         
        public void InfoManagerment()
        {
            var dep = new CDepartment();
            var cls = new CClass();
            cls._students = new List<CStudent>();
            dep._classes = new List<CClass>();
            _dataContext = _objectInOut.ReadData();
            if (_dataContext.UniversityModel._departmentModels.Count == 0)
            {
                dep._classes.Add(cls);
                _dataContext.UniversityModel._departmentModels.Add(dep);
            }
            do
            {
                Console.WriteLine("Type to select:" + _viewInfo.GenerateInfoBoard());
                optionSelect = Console.ReadLine();
                switch (optionSelect)
                {
                    case "1"://add new
                        CStudent studentModel = _studentManagement.AddNewStudent(cls, dep, _dataContext);
                        _viewInfo.MessageForm("Added: ",studentModel._name);
                        break;
                    case "2":
                        CStudent student = _studentManagement.UpdateStudent(cls, dep, _dataContext);
                        if (student == null) _viewInfo.MessageForm("Update: ", "Failed");
                        else _viewInfo.MessageForm("Updated: ", student._id + "-" + student._name);
                        break;
                    case "3"://remove
                        var st=_studentManagement.RemoveStudent(_dataContext);
                        if (st == null) _viewInfo.MessageForm("Remove: ", "Failed");
                       else  _viewInfo.MessageForm("Remove", st._id+"-"+st._name);
                        break;
                    case "4"://show
                        Console.WriteLine(_viewInfo.ShowStudents(_dataContext));
                        break;
                    case "5"://save
                        var msg = _objectInOut.Save(_dataContext);
                        _viewInfo.MessageForm("Saved", msg);
                        break;
                    case "6"://exit without saving
                        return;
                    default:
                        return;
                }
                Console.ReadKey();
                Console.Clear();
            } while (optionSelect != "6");
        }
    }
}