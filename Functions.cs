using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonSkills
{
    public static class Functions
    {
        public static TimeSpan TimeBeforeMarathonStart()
        {
            return Settings.MarathonStart - DateTime.Now;
        }
    }
}
