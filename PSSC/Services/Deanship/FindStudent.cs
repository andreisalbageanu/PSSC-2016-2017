using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicii.Deanship
{
    public class FindStudent
    {

        public FindStudent()
        {

        }

        public Models.Student.Student FindStudentMethod(string studentName)
        {
            var repository = new Repositories.Deanship.RepositoryDeanship();
            Models.Student.Student student = repository.GasesteStudentDupaNume(studentName);

            return student;

        }
    }
}
