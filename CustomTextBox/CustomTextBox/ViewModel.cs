using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTextBox
{
    public class ViewModel
    {
        public string test { get; set; }
        public Func<string, bool> Matches
        {
            get { return x => x.Contains(test); }
        }

    }
}
