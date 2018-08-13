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

        /// <summary>
        /// Returns the time of the alarm as a formatted String
        /// </summary>
        /// <returns>Formated string of alarm's time</returns>
        public String getTime()
        {
            String time = "";

            time += this.hour.ToString();
            time += ":";
            if (this.min < 10)
            {
                time += 0;
            }
            time += min;
            if (this.am)
            {
                time += " AM";
            }
            else
            {
                time += " PM";
            }

            return time;
        }
    }
}
