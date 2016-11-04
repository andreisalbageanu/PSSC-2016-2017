using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Professor
{
    public class ProfessorRepository : IRepositoryProfessor
    {
        private static List<Models.Professor.Professor> _professor = new List<Models.Professor.Professor>();


        public ProfessorRepository()
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

    }
}
