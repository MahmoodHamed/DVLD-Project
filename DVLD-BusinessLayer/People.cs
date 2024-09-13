using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;
namespace DVLD_BusinessLayer
{
    public class People
    {
        private enum Mode { Add = 1, Update = 2 };
        Mode enMode = Mode.Add;
        public int PersonID { get; set; }
        public string NationalNo {get; set;}
        public string FirstName {get; set;}
        public string SecondName {get; set;}
        public string ThirdName {get; set;}
        public string LastName {get; set;}
        public DateTime DateOfBirth {get; set;}
        public short Gendor {get; set;}
        public string Address {get; set;}
        public string Phone {get; set;}
        public string Email {get; set;}
        public int NationalityCountryID {get; set;}
        public string ImagePath { get; set; }


        public People(int PersonID, string NationalNo, string FirstName,
     string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, short Gendor,
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

            enMode = Mode.Update;
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
            Gendor = -1;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";

            enMode = Mode.Add;

        }


        public static DataTable GetAllPeople()
        {
            DataTable dt = PeopleData.GetAllPeople();
            return dt;
        }
        public static People GetPersonInfoByPersonID(int PersonID)
        {
            People Person;

            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gendor = -1;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";
            if (PeopleData.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, 
                ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
                ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                Person = new People(PersonID, NationalNo, FirstName, SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone
                ,Email, NationalityCountryID, ImagePath);
            }else
            {
                Person =null;
            }
            return Person;
        }

        public static People GetPersonInfoByNationalNo(string NationalNo)
        {
            People Person;

            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gendor = -1;
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

    }
}
