using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AIE_27_SaveContactList
{
    class Contact
    {
        public string name = "";
        public string email = "";
        public string phone = "";

        public Contact()
        {

        }

        public Contact(string name, string email, string phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }
    }
}
