using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
namespace BUS
{
    public class BUS_Users :  Connection_DAL
    {
        public void DisplayBeforImport(DataGridView grv, string fileName)
        {
            grv.DataSource = ReadFile(fileName);
        }
        public string Encryp(string pass_raw)
        {
            MD5 mh = MD5.Create();                                              //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass_raw);  //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);                           //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X"));
            }
            return sb.ToString();
        }
        public void ImportUser(string fileName,ProgressBar pro)
        {
            int i = 1;
            List<User> listUserImport = new List<User>();
            listUserImport = ReadFile(fileName);
            pro.Minimum = 1;
            pro.Maximum = listUserImport.Count;
            foreach (User u in listUserImport)
            {
                pro.Value = i;
                if (!dal_user.checkEmail(u.Email))
                {
                    dal_user.ImportUser(u);
                }
                i++;
            }
        }
        public bool AddUser(string email, string FName, string LName, string office, DateTime birthday, string pass)
        {
            User u = new User();
            if (dal_user.checkEmail(email))
            {
                return false;
            }
            u.Email = email;
            u.FirstName = FName;
            u.LastName = LName;
            u.OfficeID = dal_office.getOfficeId(office);
            u.Birthdate = birthday;
            u.Password = Encryp(pass);
            u.RoleID = 2;
            u.Active = true;
            dal_user.ImportUser(u);
            return true;
        }
        private List<User> ReadFile(string fileName)
        {
            List<User> list = new List<User>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        User u = new User();
                        string[] array = line.Split(',');
                        u.RoleID = dal_role.getRoleIdByTitle(array[0]);
                        u.Email = array[1];
                        u.Password = Encryp(array[2]);
                        u.FirstName = array[3];
                        u.LastName = array[4];
                        u.OfficeID = dal_office.getOfficeId(array[5]);
                        u.Birthdate = DateTime.Parse(array[6]);
                        if (array[7] == "1")
                            u.Active = true;
                        else
                            u.Active = false;
                        list.Add(u);
                    }
                }
            }
            catch (Exception)
            {
            }
            return list;
        }
        public int Login(string username, string pass)
        {
            return dal_user.checkLogin(username, Encryp(pass));
        }
        public int getRoleIdByEmail(string email)
        {
            return dal_user.getRoldIdByEmail(email);
        }
        public void DisplayDataByOfficeName(string name, DataGridView grv)
        {
            grv.DataSource = dal_user.getDataUserByTitle(name);
            changColor(grv);
        }
        public void changRoleByEmail(string email, int role)
        {
            dal_user.changeRoleByEmail(email, role);
        }
        public void getEmailToComboBox(ComboBox cb) // thêm "All email" vào list
        {
            List<string> list = dal_user.getListEmail();
            list.Insert(0, "All email");
            cb.DataSource = list;
        }
        public void getEmailToCombobox2(ComboBox cb) // ko thêm "All email" vào list
        {
            List<string> list = dal_user.getListEmail();
            cb.DataSource = list;
        }
        public string getLNameByEmail(string email)
        {
            return dal_user.getLNameByEmail(email);
        }
        public string getFNameByEmail(string email)
        {
            return dal_user.getFNameByEmail(email);
        }
        public void changeActiveByEmail(string email)
        {
            dal_user.changActiveByEmail(email);
        }
        public void changColor(DataGridView dg)
        {
            int k = dg.RowCount;
            for (int i = 0; i < k; i++)
            {
                DataGridViewRow row = dg.Rows[i];
                if (dal_user.checkActivityByEmail(row.Cells["EmailAddres"].Value.ToString()))
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.White;
                else
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.Red;

            }
        }
        public string getOfficeNameByEmail(string email)
        {
            return dal_user.getOfficeNameByEmail(email);
        }
    }
}
