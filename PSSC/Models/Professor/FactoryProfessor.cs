using Models.Generics;
using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Models.Professor
{
    public class FactoryProfessor
    {
        public static readonly FactoryProfessor Instance = new FactoryProfessor();

        private FactoryProfessor()
        {

        }

        public Professor CreateProfessor(string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    nume.Length >= 2 && nume.Length <= 20,
                    "Numele Profesorului trebuie sa contina intre 2 si 20 de caractere.");

            var profesor = new Professor(
                                        new PlainText(nume));

            return profesor;
        }



    }
}
