using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_Offices : database
    {
        
        public int getOfficeId(string title)
        {
            Office tmp = db.Offices.SingleOrDefault(o => o.Title == title);
            return tmp.ID;
        }
        public List<string> getOfficeName()
        {
            List<string> listOfficeName = new List<string>();
            var data = from office in db.Offices
                       select office;
            foreach (Office o in data)
            {
                listOfficeName.Add(o.Title);
            } 
            return listOfficeName;
        }
    }
}
