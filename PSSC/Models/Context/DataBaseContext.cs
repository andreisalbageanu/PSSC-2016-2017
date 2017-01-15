using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Models.Context
{
    public class DataBaseContext:DbContext
    {
        public virtual DbSet<Professor.Professor> Professors { get; set; }
        public virtual DbSet<Subject.SubjectSituation> Situation { get; set; }
        public virtual DbSet<Student.Student> Students { get; set; }
        public virtual DbSet<Subject.Subject> Subjects { get; set; }
    }
}
