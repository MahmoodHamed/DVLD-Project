using System;
using System.Data;
using DVLD_DataAccessLayer;
using System.IO;
namespace DVLD_BusinessLayer
{
    public class People
    {
        public enum EnMode { Add = 1, Update = 2 };
        public EnMode Mode = EnMode.Add;

        
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }


        public People(int PersonID, string NationalNo, string FirstName,
     string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor,
     string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = EnMode.Update;
        }

        public People()
        {
            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Gendor = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";

            Mode = EnMode.Add;

        }


        public static DataTable GetAllPeople()
        {
            DataTable dt = PeopleData.GetAllPeople();
            return dt;
        }
        public static People FindByID(int PersonID)
        {
            People Person;

            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";
            if (PeopleData.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
                ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                Person = new People(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone
                , Email, NationalityCountryID, ImagePath);
            }
            else
            {
                Person = null;
            }
            return Person;
        }

        public static People FindByNationalNo(string NationalNo)
        {
            People Person;

            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";
            if (PeopleData.GetPersonInfoByNationalNo(ref PersonID, NationalNo, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
                ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                Person = new People(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone
                , Email, NationalityCountryID, ImagePath);
            }
            else
            {
                Person = null;
            }
            return Person;
        }
       
        private bool _AddNewPerson()
        {
            this.PersonID = PeopleData.AddNewPerson(this.NationalNo, this.FirstName,
      this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor,
      this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);


            return (PersonID != -1);
        }

        private bool _UpdatePersonInfo()
        {
            return PeopleData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName,
     this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor,
     this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        public static bool DeletePersonByID(int PersonID)
        {
            return PeopleData.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return PeopleData.IsPersonExist(PersonID);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return PeopleData.IsPersonExist(NationalNo);
        }

        public bool Save()
        {

            bool IsSaved = false;
            switch (Mode)
            { 
                case EnMode.Add:
                    if (_AddNewPerson())
                    {

                        Mode = EnMode.Update;
                        IsSaved = true;
                    }
                    else
                    {
                        IsSaved = false;
                    }
                    break;
                case EnMode.Update:

                    IsSaved = _UpdatePersonInfo();
                    break;  
            }

            return IsSaved;
        }
    } 
}
