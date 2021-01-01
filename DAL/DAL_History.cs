using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_History : database
    {
        public object getHistoryByEmail(string email)
        {
            var data = from h in db.Histories
                       where h.Email == email
                       select new
                       {
                           h.Date,
                           h.LoginTime,
                           h.LogoutTime,
                           h.TimeOnSystem,
                           h.LogoutReason       
                       };
            return data;
        }
        public History getHistoryFinalByEmail(string email)
        {
            List<History> list = getAllHistoryByEmail(email);
            return list[list.Count-1];
        }
        public string getFinalDateLoginByEmail(string email)
        {
            History h = getHistoryFinalByEmail(email);
            return  h.Date.ToString();
        }
        public TimeSpan getFinalTimeLoginByEmail(string email)
        {
            History h = getHistoryFinalByEmail(email);
            return  (TimeSpan) h.LoginTime;
        }
        public int getCrashByEmail(string email,TimeSpan timeIn)
        {
            var data = from h in db.Histories
                       where  h.LogoutReason!="" && h.Email==email && h.LoginTime!= timeIn
                       select (h);
            return data.Count();
        }
        public List<History> getAllHistoryByEmail(string email)
        {
            List<History> list=new List<History>();
            var data = from h in db.Histories
                       where h.Email==email
                       select h;
            foreach (History h in data)
                list.Add(h);
            return list;
        }
        public void addHistory(History h)
        {
            var data = from h2 in db.Histories
                       select h2;
            h.ID = data.Count()+1;
            h.LogoutReason = "No Logout Detected";
            db.Histories.InsertOnSubmit(h);
            db.SubmitChanges();
        }
        public void updateTimeOut(History h)
        {
            History h2 = db.Histories.SingleOrDefault(h3 => h3.Date == h.Date && h3.LoginTime == h.LoginTime&&h3.Email==h.Email);
            h2.LogoutTime = h.LogoutTime;
            h2.LogoutReason = h.LogoutReason;
            h2.TimeOnSystem = getTimeOn(TimeSpan.Parse( h2.LoginTime.ToString()),TimeSpan.Parse( h2.LogoutTime.ToString()));
            db.SubmitChanges();
        }
        public void updateReason(History h)
        {
            History h2 = getHistoryFinalByEmail(h.Email);
            h2.LogoutReason = h.LogoutReason;
            db.SubmitChanges();
        }
        private TimeSpan getTimeOn(TimeSpan timeIn, TimeSpan TimeOut)
        {
            return TimeOut - timeIn;       
        }
        public List<TimeSpan> getAllTimeUseByEmail(string email)
        {
            DateTime today=DateTime.Today;

            List<TimeSpan> listTime = new List<TimeSpan>();
            var data = from h in db.Histories
                       where h.Email == email
                       select h;
            foreach (History item in data)
            {
                try
                {
                    TimeSpan n = TimeSpan.Parse((today - item.Date).ToString());
                    if(n.TotalDays<=30)
                        listTime.Add(TimeSpan.Parse(item.TimeOnSystem.ToString()));
                }
                catch (Exception)
                {
                    
                }
            }
            return listTime;
        }
    }
}
