using Models.Generics;
using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Models.Subject
{
    class FactorySubject
    {
        public Subject CreateSubject(string name,int credits,EvaluationType examtype,Proportion prop)
        {
            Contract.Requires<ArgumentNullException>(name != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    name.Length >= 2 && name.Length <= 50,
                    "Numele disciplinei trebuie sa contina intre 2 si 50 de caractere.");

            var subject = new Subject( new SubjectInformation( new PlainText(name),new Credits(credits),examtype,prop));

            return subject;
        }
    }
}
