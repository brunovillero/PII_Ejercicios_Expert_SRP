using System;

namespace Library
{
    public class Clinic
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

        private string address;
        public string Address 
        { 
            get 
            {
                return this.address;
            }
            set
            {
                if(! string.IsNullOrEmpty(value))
                {
                    this.address = value;
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
        public Clinic(string name, string address, string phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
    }
}
