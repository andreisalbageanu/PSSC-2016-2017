using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Professor
{
    //Entity Professor
    [Table("studentdetails")]
    public class Professor
    {
        [Key]
        
        public PlainText CNP { get; internal set; }
        public PlainText Name { get; internal set; }
        
        public Professor(PlainText name,PlainText cnp)
        {
            Name = name;
            CNP = cnp;
        }
    }
}
