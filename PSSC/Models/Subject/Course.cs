using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    //Curs apartinand disciplinelor avand un anumit nr de ore
    public class Course
    {
        public int _hours { get; internal set; }
        
        public Course(int hours)
        {
            _hours = hours;
        }
    }
}
