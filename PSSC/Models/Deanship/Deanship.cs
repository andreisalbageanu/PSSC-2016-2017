﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;

namespace Models.Deanship
{
    //Decanatul stabileste disciplinele si inregistreaza profesorii si studentii
    public class Deanship : IReportStrategy
    {
        public Deanship()
        {

        }

       public PlainText GenerateReport(Subject.Subject sub,RegistrationNumber reg)
        {
            
            Subject.SubjectSituation situation;
            situation = sub.GetSituationForStudent(reg);
            string reportString = situation.ExamGrades.ToString() +"\n"+ situation.Attendance.Count.ToString() +"\n" + situation.Lab.ActivityGrade.ToString() +"\n";
            PlainText reporttext = new PlainText(reportString);
            return reporttext;

        }
    }
}
