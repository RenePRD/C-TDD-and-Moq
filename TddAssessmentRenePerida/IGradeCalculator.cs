﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    public interface IGradeCalculator
    {
        string GetClassification(double mark);
    }
}
