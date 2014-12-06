using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTime
{
    class ReminderAI
    {

        private static List<BreakDetail> splitOut(List<BreakSummary> breakSummary)
        {
            List<BreakDetail> listBreakDetail = new List<BreakDetail>();

            foreach (var item in breakSummary)
            {
                for (int i = 0; i < item.Occurance; i++)
                {
                    listBreakDetail.Add(new BreakDetail()
                    {
                        BreakType = item.BreakType,
                        Duration = item.Duration
                    });
                }
            }

            return listBreakDetail;
        }

        public static List<Appointment> CaculateReminders(List<Appointment> currentAppointments, List<BreakSummary> breakSummaries, DateTime StartDateTime, DateTime EndDateTime)
        {

            List<Appointment> listReminders = new List<Appointment>();


            var breaksNeedOpenSlots = breakSummaries.Where(x => x.Duration >= 10);

            List<BreakDetail> breakDetails = splitOut(breaksNeedOpenSlots.ToList());
            int breaksNeedOpenSlotsCount = breaksNeedOpenSlots.Sum(x=>x.Occurance);
            int minituesBetweenBreaks = ((int)(EndDateTime - StartDateTime).TotalMinutes)/(breaksNeedOpenSlotsCount+1);


            DateTime currentTime = StartDateTime.AddMinutes(minituesBetweenBreaks);

            foreach(var breakDetail in breakDetails)
            {
                if(currentTime >= EndDateTime)
                    break;

                var conflictAppt =  currentAppointments.FirstOrDefault(x=>x.StartTime <=currentTime && x.EndTime > currentTime );

                while(conflictAppt!=null){
                    currentTime = conflictAppt.EndTime;
                    conflictAppt = currentAppointments.FirstOrDefault(x => x.StartTime <= currentTime && x.EndTime > currentTime);

                }

                listReminders.Add(new Appointment()
                {
                    Subject = breakDetail.BreakType,
                    EndTime = currentTime.AddMinutes(breakDetail.Duration),
                    StartTime = currentTime,
                });

                currentTime = currentTime.AddMinutes(minituesBetweenBreaks);

            }

            var breaksOther = breakSummaries.Where(x => x.Duration < 10);

            breakDetails = splitOut(breaksOther.ToList());
            int breakOtherCount = breaksOther.Sum(x => x.Occurance);
            minituesBetweenBreaks = ((int)(EndDateTime - StartDateTime).TotalMinutes) / (breakOtherCount + 1);

            currentTime = StartDateTime.AddMinutes(minituesBetweenBreaks);

            foreach (var breakDetail in breakDetails)
            {
                if (currentTime >= EndDateTime)
                    break;

                listReminders.Add(new Appointment()
                {
                    Subject = breakDetail.BreakType,
                    EndTime = currentTime.AddMinutes(breakDetail.Duration),
                    StartTime = currentTime,
                });

                currentTime = currentTime.AddMinutes(minituesBetweenBreaks);

            }




            return listReminders;



        }

    }
}
