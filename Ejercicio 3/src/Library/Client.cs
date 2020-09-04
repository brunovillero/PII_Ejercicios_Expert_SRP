using System;

namespace Library
{
    public class Client
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

        private string id;
        public string Id 
        { 
            get 
            {
                return this.id;
            }
            set
            {
                if(! string.IsNullOrEmpty(value))
                {
                    this.id = value;
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

        public Client(string name, string id, string phoneNumber)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }
    }
}
