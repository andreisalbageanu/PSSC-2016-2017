using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicii.Deanship
{
    public class AddStudent
    {
        AddStudent()
        {

        }

        public string AddStudentMethod(Models.Student.Student student)
        {
            var repository = new Repositories.Deanship.RepositoryDeanship();
            repository.AdaugaStudent(student);

            return "Success";

        }
    }
}
