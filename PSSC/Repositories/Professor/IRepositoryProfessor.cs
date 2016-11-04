using System;
using Models;
namespace Repositories.Professor
{
    interface IRepositoryProfessor
    {
        void ActualizeazaProfesor(Models.Professor.Professor professor);
        void AdaugaProfesor(Models.Professor.Professor professor);
        Models.Professor.Professor GasesteProfesorDupaNume(string name);
    }
}
