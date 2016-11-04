using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    public class Course
    {
        public int _hours { get; internal set; }
        
        public Course(int hours)
        {
            _hours = hours;
        }
    }
}
