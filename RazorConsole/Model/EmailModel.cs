using System;
using System.Collections.Generic;
using System.Text;

namespace RazorConsole.Model
{
    public class EmailModel
    {
        public string Sender { get; set; }
        public string To { get; set; }
        public string Text { get; set; }
        public int UserData1 { get; set; }
        public int UserData2 { get; set; }

    }
}
