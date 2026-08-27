using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university_AccessDataLayer;

namespace university_BussinesLayer
{
    public class clsPerson
    {

        public enum enMode {Add = 0 , Update = 1}
        private enMode _Mode;


        public int PersonID { get; set; }


        public string FirstName { get; set; }


        public string MiddleName { get; set; }



        public string LastName { get; set; }



        public string Email { get; set; }



        public string Phone { get; set; }



        public clsPerson()
        {
            this.PersonID = 0;
            this.FirstName = "";
            this.MiddleName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";

            _Mode = enMode.Add;
        }


        private clsPerson(int PersonID , string FirstName , string MiddleName 
            , string LastName , string Email , string Phone)
        {
            this.PersonID= PersonID;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;

            _Mode = enMode.Update;
        }


        public static clsPerson FindPersonInfo(int PersonID)
        {
            string FirstName = ""
            , MiddleName = "" 
            , LastName = "" 
            , Email = "" 
            , Phone = "" ;
            if (clsPersonData.FindPersonInfo(PersonID , ref FirstName 
                ,ref MiddleName , ref LastName , ref Email , ref Phone))
            {
                return new clsPerson(PersonID , FirstName , MiddleName , LastName 
                    ,Email, Phone);
            }
            else
            {
                return null;
            }
        }


        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.InsertNewPersonInfo(FirstName , LastName , MiddleName , Email , Phone);
            return (this.PersonID != 0);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePersonInfo(PersonID , FirstName , MiddleName 
                , LastName , Email , Phone);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    if (_AddNewPerson())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();
            }


            return false;
        }


        public static bool DeletePersonUsingID(int PersonID)
        {
            return clsPersonData.DeletePersonUsingID(PersonID);
        }
    }
}
