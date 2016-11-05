using System;
using Models;
namespace Repositories.Deanship
{
    interface IRepositoryDeanship
    {
        void ActualizeazaProfesor(Models.Professor.Professor professor);
        void AdaugaProfesor(Models.Professor.Professor professor);
        Models.Professor.Professor GasesteProfesorDupaNume(string name);
        void ActualizeazaStudent(Models.Student.Student student);
        void AdaugaStudent(Models.Student.Student student);
        Models.Student.Student GasesteStudentDupaNume(string name);
    }
}
