using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicii.Deanship
{
    public class AddProfessor
    {
        public AddProfessor()
        {

        }

        public string AddProfessorMethod(Models.Professor.Professor professor)
        {
            var repository = new Repositories.Deanship.RepositoryDeanship();
            repository.AdaugaProfesor(professor);

            return "Success";

        }

    }
}
