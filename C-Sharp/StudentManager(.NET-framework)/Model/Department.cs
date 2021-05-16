using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    [Serializable]
    class CDepartment:CUniversity
    {
        public List<CClass> _classes = new List<CClass>();
    }
}
