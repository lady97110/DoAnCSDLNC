using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Classes
{
    class Customer
    {
        private int customerId;
        private string name;
        private string dob;
        private string phoneNumber;
        private string identification;
        private string accountNumber;
        private string address;

        public Customer()
        {
            
        }

        public Customer(int customerId, string name, string dob, string phoneNumber, string identification, string accountNumber, string address)
        {
            this.customerId = customerId;
            this.name = name;
            this.dob = dob;
            this.phoneNumber = phoneNumber;
            this.identification = identification;
            this.accountNumber = accountNumber;
            this.address = address;
        }

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Identification
        {
            get
            {
                return identification;
            }

            set
            {
                identification = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }

            set
            {
                accountNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
    }
}
