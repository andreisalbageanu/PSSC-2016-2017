
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pdf;
using Repositories;



namespace Servicii
{
    public class ReportSubjectSituation
    {
        public ReportSubjectSituation()
        { 
        }

        public void ReportSituation(string subjectName)
        {
            var repository = new Repositories.Subject.RepositorySubject();
            Models.Subject.Subject subject = repository.subject(subjectName);
            var continutRaport = new List<List<string>>();
            foreach (var student in subject.SignedUpStudentsGrades )
            {
                var line = new List<string>();
                line.Add(student.ToString());
                if (student.Value != null)
                {
                    line.Add(student.Value.Lab.ActivityGrade.ToString());
                }
                else
                {
                    line.Add("");
                }

                if (student.Value.ExamGrades != null)
                {
                    line.Add(student.Value.ExamGrades.ToString());
                }
                else
                {
                    line.Add("");
                }

                continutRaport.Add(line);
            }

            //genereaza PDF
            var pdf = new GeneratorRapoartePdf();
            var locatie = pdf.GenerareRaportTabelar(continutRaport);
            }


        }

    }

