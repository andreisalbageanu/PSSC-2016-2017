using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //Entity Professor
    public class Professor
    {
        public PlainText Name { get; internal set; }

        public PlainText CNP { get; internal set; }
        public Professor(PlainText name,PlainText cnp)
        {
            Name = name;
            CNP = cnp;
        }
    }
}
