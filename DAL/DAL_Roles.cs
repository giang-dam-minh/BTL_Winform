using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public  class DAL_Roles : database
    {       
        public int getRoleIdByTitle(string title)
        {
            Role r = db.Roles.SingleOrDefault(role => role.Title == title);
            return r.ID;
        }  
    }
}
