using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace Repositories.Student
{
    public class StudentRepository : IRepositoryStudent
    {
        private static List<Models.Student.Student> _student = new List<Models.Student.Student>();
        

        public StudentRepository()
        {
        }

        public void AdaugaStudent(Models.Student.Student student)
        {
            var result = _student.FirstOrDefault(d => d.Equals(student));

            if (result != null) throw new DuplicateWaitObjectException();

            _student.Add(student);
            Console.WriteLine("Un nou Student a fost adaugat.");
        }
        

        public void ActualizeazaStudent(Models.Student.Student student)
        {

            Console.WriteLine("Modificarile au fost salvate.");
        }
        

        public Models.Student.Student GasesteStudentDupaNume(string name)
        {
            return _student.FirstOrDefault(d => d.Name.Text == name);
        }
       
    }
}
