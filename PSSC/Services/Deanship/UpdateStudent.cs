using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicii.Deanship
{
    public class UpdateStudent
    {
       public UpdateStudent()
        {

        }

       public string UpdateStudentMethod(Models.Student.Student student)
       {
           var repository = new Repositories.Deanship.RepositoryDeanship();
           repository.ActualizeazaStudent(student);

           return "Success";

       }

    }
}
