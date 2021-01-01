using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
namespace BUS
{
    public class BUS_Offices : Connection_DAL
    {
        public void getOfficeNameToComboBox(ComboBox cb) // thêm "All offices" vào list
        {
            List<string> listOfficeName = new List<string>();
            listOfficeName = dal_office.getOfficeName();
            listOfficeName.Insert(0, "All offices");
            cb.DataSource = listOfficeName;
        }
        public void getOfficeNameToComboBox2(ComboBox cb) // ko thêm "All offices" vào list
        {
            cb.DataSource = dal_office.getOfficeName();
        }
    }
}
