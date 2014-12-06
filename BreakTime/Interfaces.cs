using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTime
{
    interface CalendarInterface
    {
        List<Appointment> GetAllAppointmentsForDateRange(DateTime startDateTime, DateTime endDateTime);


        void SetAppointments(List<Appointment> appointments);


    }
}
