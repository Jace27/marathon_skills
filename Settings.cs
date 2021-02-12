using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonSkills
{
    public static class Settings
    {
        public static MainWindow MainWindow;
        public static DateTime MarathonStart = new DateTime(2021, 10, 21, 12, 10, 0);
        public static Task Timer;
        public static bool TimerRunning = true;
    }
}
