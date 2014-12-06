using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace BreakTime
{
    class OutlookCalendar : CalendarInterface
    {    
        //return list of appointments
        public  List<Appointment> GetAllAppointmentsForDateRange(DateTime startDateTime, DateTime endDateTime)
        {
            Outlook.Application OlApp = new Outlook.Application();
            Outlook.Folder calendarFolder = OlApp.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar) as Outlook.Folder;
            //g: 6/15/2008 9:15 PM (format)
            string filter = string.Format("[Start] >= '{0}' AND [End] <= '{1}'", startDateTime.ToString("g"), endDateTime.ToString("g"));
            Debug.WriteLine(filter);

            try
            {
                Outlook.Items calendarItems = calendarFolder.Items;
                calendarItems.IncludeRecurrences = true;
                calendarItems.Sort("[Start]", Type.Missing);
                Outlook.Items restrictItems = calendarItems.Restrict(filter);
                if (restrictItems.Count > 0)    //Meetings exist
                {
                    List<Appointment> appointments = new List<Appointment>();
                    foreach (Outlook.AppointmentItem appt in restrictItems)
                    {
                        appointments.Add(new Appointment()
                        {
                             StartTime = appt.Start,
                             EndTime = appt.End
                        });
                    }
                    return appointments;
                }
                else  //No Meetings
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return null;
            }
        }

        public  void SetAppointments(List<Appointment> appointments){
            
            Outlook.Application application = new Outlook.Application();

            foreach (var appointment in appointments)
            {
                Outlook.AppointmentItem appt = application.CreateItem(
                Outlook.OlItemType.olAppointmentItem)
                as Outlook.AppointmentItem;
                appt.Subject = appointment.Subject;
                //appt.Location = Location;
                appt.Sensitivity = Outlook.OlSensitivity.olPrivate;
                appt.Start = appointment.StartTime; //"10/21/2006 10:00 AM"
                appt.End = appointment.EndTime; //"10/21/2006 3:00 PM"
                appt.ReminderSet = true;
                appt.ReminderMinutesBeforeStart = 0;
                appt.Save();
            }
        }

    }
}
