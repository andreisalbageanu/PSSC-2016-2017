using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;

namespace Models.Subject
{
    public class Laboratory
    {
        public Grade ActivityGrade { get; internal set; }
        public Proportion ActivityProportion { get; internal set; }
        public Laboratory(Grade activityGrade,Proportion activityProportion )
        {
            ActivityGrade = activityGrade;
            ActivityProportion = activityProportion;
        }
    }
}
