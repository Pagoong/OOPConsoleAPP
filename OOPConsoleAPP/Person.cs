using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP
{
    public class Person
    {
        public virtual string Work()
        {
            return "Person is working.";
        }
    }

    public class Student : Person
    {
        public override string Work()
        {
            return "Student is studying.";
        }
    }

    public class Teacher : Person
    {
        public override string Work()
        {
            return "Teacher is teaching.";
        }
    }
}
