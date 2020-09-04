using System;

namespace Library
{
    public class Doctor
    {
        private string name;
        public string Name 
        {   get
            {
                return this.name;
            }
            set 
            {
                if(! string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        private string speciality;
        public string Speciality 
        { 
            get 
            {
                return this.speciality;
            }
            set
            {
                if(! string.IsNullOrEmpty(value))
                {
                    this.speciality = value;
                }
            }
        }

        private string phoneNumber;
        public string PhoneNumber 
        { 
            get 
            {
                return this.phoneNumber;
            } 
            set
            {
                if(! string.IsNullOrEmpty(value))
                {
                    this.phoneNumber = value;
                }
            }
        }
        public Doctor(string name, string speciality, string phoneNumber)
        {
            this.Name = name;
            this.Speciality = speciality;
            this.PhoneNumber = phoneNumber;
        }
    }
}
