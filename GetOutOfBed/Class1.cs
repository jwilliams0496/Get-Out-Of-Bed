using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetOutOfBed
{
    public class Alarm
    {
        private int hour;
        private int min;
        private bool am;

        /// <summary>
        /// Creates a new Alarm object
        /// </summary>
        /// <param name="h">Hour of the alarm as an int</param>
        /// <param name="m">Minute of the alarm as an int</param>
        /// <param name="a">Bool of the alarm is in the AM</param>
        public Alarm(int h, int m, bool a)
        {
            this.hour = h;
            this.min = m;
            this.am = a;
        }
    }
}
