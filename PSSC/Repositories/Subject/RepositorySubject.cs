using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Subject;

namespace Repositories.Subject
{
    public class DecanatRepository : IRepositorySubject
    {
       
        private static List<Models.Subject.Subject> _subject = new List<Models.Subject.Subject>();

        public DecanatRepository()
        {
        }
        public void AdaugaSubject(Models.Subject.Subject subject)
        {
            var result = _subject.FirstOrDefault(d => d.Equals(subject));

            if (result != null) throw new DuplicateWaitObjectException();

            _subject.Add(subject);
            Console.WriteLine("O noua disciplina cu examen Distribuit a fost adaugata.");
        }
        public void ActualizeazaSubject(Models.Subject.Subject subject)
        {
            Console.WriteLine("Modificarile au fost salvate.");
        }
        public Models.Subject.Subject subject(string name)
        {
            return _subject.FirstOrDefault(d => d.SubjectInfo.Name.Text == name);
        }
    }
}