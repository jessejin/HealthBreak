using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace BreakTime
{
    public partial class FormSettings : DevExpress.XtraEditors.XtraForm
    {
        List<CheckEdit> ceList = new List<CheckEdit>();
        List<TextEdit> txtBreakTypeList = new List<TextEdit>();
        List<ComboBoxEdit> cbDurationList = new List<ComboBoxEdit>();
        List<SpinEdit> spinBreaksList = new List<SpinEdit>();


        public FormSettings()
        {
            InitializeComponent();
        }


        private void FormSettings_Load(object sender, EventArgs e)
        {

            ceList.Add(checkEdit1);
            ceList.Add(checkEdit2);
            ceList.Add(checkEdit3);
            ceList.Add(checkEdit4);

            //BreakTypeList
            txtBreakTypeList.Add(txtBreakType1);
            txtBreakTypeList.Add(txtBreakType2);
            txtBreakTypeList.Add(txtBreakType3);
            txtBreakTypeList.Add(txtBreakType4);


            //DurationList
            cbDurationList.Add(cbDuration1);
            cbDurationList.Add(cbDuration2);
            cbDurationList.Add(cbDuration3);
            cbDurationList.Add(cbDuration4);


            //SpinBreakList
            spinBreaksList.Add(spinBreaks1);
            spinBreaksList.Add(spinBreaks2);
            spinBreaksList.Add(spinBreaks3);
            spinBreaksList.Add(spinBreaks4);


            foreach (var cb in ceList)
            {
                cb.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            }


        }

        private void checkEdit_CheckedChanged(object sender, EventArgs e)
        {

            DevExpress.XtraEditors.CheckEdit cb = (DevExpress.XtraEditors.CheckEdit)sender;
            int cbIndex = Convert.ToInt32(cb.Tag) - 1;

            txtBreakTypeList[cbIndex].Enabled = cb.Checked;
            cbDurationList[cbIndex].Enabled = cb.Checked;
            spinBreaksList[cbIndex].Enabled = cb.Checked;

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
//            AddReminder("Do Some walking for 5 mins", "Newar Chair", "12/06/2014 03:57 AM", "12/06/2014 10:00 AM");
                        
            CalendarInterface calendar = new OutlookCalendar();
            var currentAppointments = calendar.GetAllAppointmentsForDateRange( DateTime.Today, DateTime.Today.AddDays(1));


            var reminders = ReminderAI.CaculateReminders(currentAppointments, GetBreakSummaries(), DateTime.Today+  timeEditStart.Time.TimeOfDay, DateTime.Today+ timeEditEnd.Time.TimeOfDay);

            calendar.SetAppointments(reminders);

            Hide();
            notifyIcon1.BalloonTipTitle = "Health Break";
            notifyIcon1.BalloonTipText = "Health Break will setup reminders for you in the background.";
            notifyIcon1.ShowBalloonTip(3000);
        }


        private List<BreakSummary> GetBreakSummaries()
        {

            List<BreakSummary> listBreakSummary = new List<BreakSummary>();
            foreach (var cb in ceList)
            {
                if (cb.Checked)
                {
                    int cbIndex = Convert.ToInt32(cb.Tag) - 1;
                    listBreakSummary.Add(new BreakSummary()
                    {

                        BreakType = txtBreakTypeList[cbIndex].Text,
                        Duration = Convert.ToInt32(cbDurationList[cbIndex].Text.Split(' ')[0]),
                        Occurance = Convert.ToInt32(spinBreaksList[cbIndex].Value)

                    });


                }
            }

            return listBreakSummary;


        }

        //This is to open Windows form from NotifyIcon 
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();
        }


        private void AddReminder(string ReminderSubject, string Location, string StartTime, string EndTime)
        {
            Outlook.Application application = new Outlook.Application();

            Outlook.AppointmentItem appt = application.CreateItem(
                Outlook.OlItemType.olAppointmentItem)
                as Outlook.AppointmentItem;
            appt.Subject = ReminderSubject;
            appt.Location = Location;
            appt.Sensitivity = Outlook.OlSensitivity.olPrivate;
            appt.Start = DateTime.Parse(StartTime); //"10/21/2006 10:00 AM"
            appt.End = DateTime.Parse(EndTime); //"10/21/2006 3:00 PM"
            appt.ReminderSet = true;
            appt.ReminderMinutesBeforeStart = 0;
            appt.Save();
        }










    
  



    }
}
