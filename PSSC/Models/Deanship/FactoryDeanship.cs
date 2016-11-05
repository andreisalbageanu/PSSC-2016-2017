using Models.Generics;
using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Models.Deanship
{
    public class FactoryDeanship
    {
        public static readonly FactoryDeanship Instance = new FactoryDeanship();

        private FactoryDeanship()
        {

        }
        public Models.Student.Student CreateStudent(string reg, string name, int credits)
        {
            Contract.Requires<ArgumentNullException>(name != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    name.Length >= 2 && name.Length <= 20,
                    "Numele Studentului trebuie sa contina intre 2 si 20 de caractere.");

            var student = new Models.Student.Student(new RegistrationNumber(reg),
                                        new PlainText(name), new Credits(credits));

            return student;
        }
        public Models.Professor.Professor CreateProfessor(string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    nume.Length >= 2 && nume.Length <= 20,
                    "Numele Profesorului trebuie sa contina intre 2 si 20 de caractere.");

            var profesor = new Models.Professor.Professor(
                                        new PlainText(nume));

            return profesor;
        }
       
    }
}
