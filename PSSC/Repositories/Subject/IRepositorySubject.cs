using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Subject
{
    public interface IRepositorySubject
    {
        void AdaugaSubject(Models.Subject.Subject subject);
        void ActualizeazaSubject(Models.Subject.Subject subject);
        Models.Subject.Subject subject(string name);
    }
}
