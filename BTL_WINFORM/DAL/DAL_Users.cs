using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DAL
{
    public class DAL_Users : database
    {
        
        public void ImportUser(User u)
        {
            u.ID = Count();
            db.Users.InsertOnSubmit(u);
            db.SubmitChanges();
        }
        private int Count()
        {
            var data = from user in db.Users
                       select user;
            return data.Count() + 1;
        }
        public bool checkEmail(string email)
        {
            var data = from u in db.Users
                       where u.Email == email
                       select u;
            if (data.Count()==0)
                return false;
            return true;
        }
        public int checkLogin(string username, string pass)
        {
            User check;
            try
            {
                 check = db.Users.SingleOrDefault(u => u.Email == username && u.Password == pass);
            }
            catch (Exception)
            {
                return -2;
            }
            if (check == null) 
                return 0;
            if (checkActivityByEmail(check.Email))
                return 1;
            return -1;
        }
        public int getRoldIdByEmail(string email)
        {
            User u = db.Users.SingleOrDefault(u1 => u1.Email == email);
            return u.RoleID;
            
        }
        public object getDataUserByTitle(string title)
        {

            if (title != "All offices")
            {
                var data = from user in db.Users
                           where user.Office.Title == title
                           select new
                           {
                               Name = user.FirstName,
                               user.LastName,
                               Age = getAge(user.Birthdate.ToString()),
                               UserRole = user.Role.Title,
                               EmailAddres = user.Email,
                               Office = user.Office.Title
                           };
                return data;
            }
            else
            {
                var data = from user in db.Users                           
                           select new
                           {
                               Name = user.FirstName,
                               user.LastName,
                               Age = getAge(user.Birthdate.ToString()),
                               UserRole = user.Role.Title,
                               EmailAddres = user.Email,
                               Office = user.Office.Title
                           };
                return data;
            }
        }
        public bool checkActivityByEmail(string email)
        {
            User u = db.Users.SingleOrDefault(u1 => u1.Email == email);
            if (u.Active.ToString() == "True")
                return true;
            else return false;
        }
        public void changActiveByEmail(string email)
        {
            User u = db.Users.SingleOrDefault(u1 => u1.Email == email);
            u.Active = !u.Active;
            db.SubmitChanges();
        }
        private int getAge(string birthday)
        {
            int age = 0;
            DateTime today = DateTime.Today;
            DateTime Birthday = DateTime.Parse(birthday);
            try
            {
                string[] numberOfday = (today - Birthday).ToString().Split('.');
                age = int.Parse(numberOfday[0]);
            }
            catch (Exception)
            {
            }
            return age / 365;
        }
        public void changeRoleByEmail(string email,int role)
        {
            User u = db.Users.SingleOrDefault(u1 => u1.Email == email);
            u.RoleID = role;
            db.SubmitChanges();
        }
        public List<string> getListEmail()
        {
            List<string> list = new List<string>();
            var data = from u in db.Users
                       select u;
            foreach (User u in data)
            {
                list.Add(u.Email);
            }
            return list;
        }
        public string getLNameByEmail(string email)
        {
            User u = db.Users.SingleOrDefault(u1 => u1.Email == email);
            return u.LastName;
        }
        public string getFNameByEmail(string email)
        {
            User u = db.Users.SingleOrDefault(u1 => u1.Email == email);
            return u.FirstName;
        }
        public string getOfficeNameByEmail(string email)
        {
            User u = db.Users.SingleOrDefault(u1 => u1.Email == email);
            return u.Office.Title;          
        }
    }
}
