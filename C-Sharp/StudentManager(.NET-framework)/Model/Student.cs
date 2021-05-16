using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    [Serializable]
    class CStudent : CClass
    {
        public int _id { set; get; }
        public string _name { set; get; }
        public int _age;
    }
}
