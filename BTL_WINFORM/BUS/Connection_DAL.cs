using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
namespace BUS
{
    public class Connection_DAL
    {
        public DAL_Users dal_user = new DAL_Users();
        public DAL_Roles dal_role = new DAL_Roles();
        public DAL_Offices dal_office = new DAL_Offices();
        public DAL_History dal_history = new DAL_History();
        public DAL_Countries dal_country = new DAL_Countries();
    }
}
