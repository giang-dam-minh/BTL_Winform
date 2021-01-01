using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using System.Drawing;
namespace BUS
{
    public class BUS_Hisroty : Connection_DAL
    {
        
        public void DisplayByEmail(DataGridView dg,string email,TimeSpan timeIn)
        {
            List<History> lishHistory = new List<History>();

            dg.DataSource = dal_history.getHistoryByEmail(email);
        }   
        public int getCrashByEmail(string email,TimeSpan timeIn)
        {
            return dal_history.getCrashByEmail(email,timeIn);
        }
        public void DisplayAll(DataGridView dg)
        {
            //dg.DataSource = dal_history.getAllHistory();
            //changeColor(dg);
        }
        public bool checkFinalLogoutByEmail(string email)
        {
           History h = dal_history.getHistoryFinalByEmail(email);
            if(string.IsNullOrEmpty(h.LogoutReason))
                return true;

            return false;
        }
        public string getFinalDateLoginByEmail(string email)
        {
            return dal_history.getFinalDateLoginByEmail(email);

        }
        public TimeSpan getFinalTimeLoginByEmail(string email)
        {
            return dal_history.getFinalTimeLoginByEmail(email);
        }
        public void addHistory(string email, DateTime date, TimeSpan timeIn)
        {
            History h = new History();
            h.Email = email;
            h.Date = date;
            h.LoginTime = timeIn;
            dal_history.addHistory(h);
        }
        public void upDateTimeOut(string email, DateTime date, TimeSpan timeIn, TimeSpan timeOut,string reason)
        {
            History h=new History();
            h.Email = email;
            h.Date = date;
            h.LoginTime = timeIn;
            h.LogoutTime=timeOut;
            h.LogoutReason = reason;
            dal_history.updateTimeOut(h);
        }
        public void updateReason(string email,string reason)
        {
            History h = new History();
            h.Email = email;
            h.LogoutReason = reason;
            dal_history.updateReason(h);
            
        }
        public void changeColor(DataGridView dg)
        {
            int k = dg.RowCount;
            for (int i = 0; i < k; i++)
            {
                DataGridViewRow row = dg.Rows[i];
                if (row.Cells["LogoutReason"].Value == null||row.Cells["LogoutReason"].Value.ToString()=="")
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                else
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.Red;

            }
        }
        public TimeSpan getSumTimeUseByEmail(string email)
        {
            List<TimeSpan> listTime = dal_history.getAllTimeUseByEmail(email);
            TimeSpan time=TimeSpan.Parse("00:00:00");
            DateTime today = DateTime.Today;
            foreach (TimeSpan item in listTime)
            {
                time += item;
            }
            return time;
        }
    }
}
