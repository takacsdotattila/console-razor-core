using System;
using System.Collections.Generic;
using System.Text;

namespace RazorConsole
{
    public class EmailReportGenerator
    {
        public string GenerateReport(int userData1, int userData2)
        {
            return "A user specific report based on values '" + userData1 + "' and '" + userData2 + "'";
        }
    }
}
