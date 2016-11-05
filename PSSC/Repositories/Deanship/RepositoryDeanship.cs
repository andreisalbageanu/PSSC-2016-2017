using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Deanship
{
    public class RepositoryDeanship : IRepositoryDeanship
    {
        private static List<Models.Professor.Professor> _professor = new List<Models.Professor.Professor>();
        private static List<Models.Student.Student> _student = new List<Models.Student.Student>();

        public RepositoryDeanship()
        {
        }

        public void AdaugaProfesor(Models.Professor.Professor professor)
        {
            var result = _professor.FirstOrDefault(d => d.Equals(professor));

            if (result != null) throw new DuplicateWaitObjectException();

            _professor.Add(professor);
            Console.WriteLine("Un nou Profesor a fost adaugat.");
        }


        public void ActualizeazaProfesor(Models.Professor.Professor professor)
        {

            Console.WriteLine("Modificarile au fost salvate.");
        }


        public Models.Professor.Professor GasesteProfesorDupaNume(string name)
        {
            return _professor.FirstOrDefault(d => d.Name.Text == name);
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
