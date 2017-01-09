using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicii.Deanship
{
    public class FindProfessor
    {

        FindProfessor()
        {

        }

        public Models.Professor.Professor FindProfessorMethod(string professorName)
        {
            var repository = new Repositories.Deanship.RepositoryDeanship();
            Models.Professor.Professor professor = repository.GasesteProfesorDupaNume(professorName);

            return professor;

        }

    }
}
