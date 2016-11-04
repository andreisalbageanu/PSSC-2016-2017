using Models.Generics;
using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Models.Student
{
    public class FactoryStudent
    {
        public static readonly FactoryStudent Instance = new FactoryStudent();

        private FactoryStudent()
        {

        }

        public Student CreateStudent(string reg,string name,int credits)
        {
            Contract.Requires<ArgumentNullException>(name != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    name.Length >= 2 && name.Length <= 20,
                    "Numele Studentului trebuie sa contina intre 2 si 20 de caractere.");

            var student = new Student( new RegistrationNumber(reg),
                                        new PlainText(name),new Credits(credits));

            return student;
        }



    }
}
