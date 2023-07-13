using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    public class GradeCalculator : IGradeCalculator
    {
        public string GetClassification(double mark)
        {
            if (mark < 75)
                return "fail";
            else if (mark < 80)
                return "pass";
            else if (mark < 90)
                return "merit";
            else
                return "distinction";
        }
    }
}
