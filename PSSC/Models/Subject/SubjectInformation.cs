﻿using Models.Generics;

namespace Models.Subject
{
    //informatii despre disciplina
    public class SubjectInformation
    {
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
        public Professor.Professor Professor { get; internal set; }
        public EvaluationType Evaluation { get; internal set; }
        public Laboratory Lab { get; internal set; }
        public Course course { get; internal set; }

        public SubjectInformation()
        {

        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity)
        {
            Name = name;
            Credits = credits;
            Evaluation = type;
            Lab.ActivityProportion = activity;
        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity, Professor.Professor professor) 
            : this(name, credits, type, activity)
        {
            Professor = professor;
        }

        public void SetProfessor(Professor.Professor professor)
        {
            Professor = professor;
        }

        public void SetActivityProportion(Proportion proportion)
        {
            Lab.ActivityProportion = proportion;
        }
        public void SetCourseHours(int hours)
        {
            course._hours = hours;
        }
    }
}
