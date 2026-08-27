using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university_AccessDataLayer;

namespace university_BussinesLayer
{
    public class clsUsers
    {

        public enum enMode {Add = 0 , Update = 1}
        private enMode _Mode;

        public int UserId { get; set; }



        public string UserName { get; set; }



        public string FirstName { get; set; }



        public string MiddleName { get; set; }



        public string LastName { get; set; }



        public string Email { get; set; }



        public string Phone { get; set; }


        public string Password { get; set; }


        public int PersonID { get; set; }


        public static bool IsExistUserInSystem(string UserName , string Password)
        {
            return clsUsersData.IsExistUserInSystem(UserName, Password);
        }


        private clsUsers(int userId, string userName, string firstName, string middleName, string lastName, string email, string phone)
        {
            UserId = userId;
            UserName = userName;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;
            Phone = phone;

            _Mode = enMode.Update;
        }


        private clsUsers(int userId, string userName, string password,int PersonID)
        {
            UserId = userId;
            UserName = userName;
            this.Password = password;
            this.PersonID = PersonID;

            _Mode = enMode.Update;
        }

        public static clsUsers FindUserUsingUserName(string UserName)
        {
            int UserId = 0;
            string FirstName = null , MiddleName = null , LastName = null;
            string Email = null , Phone = null ;
            if (clsUsersData.FindUserUsingUserName(UserName , ref UserId , ref FirstName , ref MiddleName 
                , ref LastName , ref Email , ref Phone))
            {
                return new clsUsers(UserId, UserName, FirstName, MiddleName
                    , LastName, Email, Phone);
            }
            else
            {
                return null;
            }
        }


        public static clsUsers FindUserUsingUserID(int UserID)
        {
            string UserName = null;
            string FirstName = null, MiddleName = null, LastName = null;
            string Email = null, Phone = null; 
            if (clsUsersData.FindUserUsingUserID(UserID, ref UserName, ref FirstName, ref MiddleName
                , ref LastName, ref Email, ref Phone))
            {
                return new clsUsers(UserID, UserName, FirstName, MiddleName
                    , LastName, Email, Phone);
            }
            else
            {
                return null;
            }
        }


        public static clsUsers FindUserUsingUserIDFromUserTable(int UserID)
        {
            string UserName = null;
            string Password = null;
            int PersonID = -1;
            if (clsUsersData.FindUserUsingUserID(UserID, ref UserName, ref Password , ref PersonID))
            {
                return new clsUsers(UserID, UserName, Password , PersonID);
            }
            else
            {
                return null;
            }
        }


        private bool _AddNewUser()
        {
            this.UserId = clsUsersData.InsertNewUser(UserName , Password , PersonID);
            return (this.UserId != -1);
        }


        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(UserId , UserName , Password , PersonID);
        }


        public static bool DeleteUser(int UserID)
        {
            return clsUsersData.DeleteUser(UserID);
        }


        public clsUsers()
        {
            UserId = -1;
            UserName = null;
            FirstName = null;
            MiddleName = null;
            LastName = null;
            Email = null;
            Phone = null;
            PersonID = -1;
            Password = null;

            _Mode = enMode.Add;
        }


        public static bool ChangePasswordUser(string UserName , string Password)
        {
            return clsUsersData.ChangePasswordUser(UserName , Password);
        }


        public static bool IsExistPassword (string Password)
        {
            return clsUsersData.IsExistPassword(Password);
        }


        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    if (_AddNewUser())
                        return true;
                    else
                        return false;
                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }
    }
}
