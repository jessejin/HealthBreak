using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTime
{
    public class Appointment
    {
        public string Subject;
        public DateTime StartTime;
        public DateTime EndTime;
    }


    public class OpenTimeSlot
    {
        public DateTime startTime;
        public DateTime endTime;
        public int duration;
    }

    public class BreakSummary
    {
        public string BreakType;
        public int Duration;
        public int Occurance;

    }

    public class BreakDetail
    {
        public string BreakType;
        public int Duration;
    }
 
}
