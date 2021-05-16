using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    [Serializable]
    class CClass:CDepartment
    {
        public List<CStudent> _students = new List<CStudent>();
    }
}
