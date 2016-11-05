﻿using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Deanship
{
    
    //Strategy Signature
    public interface IReportStrategy
    {
        PlainText GenerateReport(Subject.Subject sub, RegistrationNumber reg);
    }

    //Strategy Context
    public interface IReportPublisher
    {
        void Publish(IReportStrategy strategy);
    }

}
