using System;
using Models;
namespace Repositories.Student
{
    interface IRepositoryStudent
    {
        void ActualizeazaStudent(Models.Student.Student student);
        void AdaugaStudent(Models.Student.Student student);
        Models.Student.Student GasesteStudentDupaNume(string name);
    }
}
