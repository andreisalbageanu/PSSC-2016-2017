using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicii.Deanship
{
    class UpdateProfessor
    {
        UpdateProfessor()
        {

        }

        public string UpdateProfessorMethod(Models.Professor.Professor professor)
        {
            var repository = new Repositories.Deanship.RepositoryDeanship();
            repository.ActualizeazaProfesor(professor);

            return "Success";

        }
    }
}
