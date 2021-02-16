using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_28_HighScoresTable
{
    class Contact
    {
        public string name = "";
        public string email = "";


        public Contact()
        {

        }

        public Contact(string name, string email)
        {
            this.name = name;
            this.email = email;
            
        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} ");
        }
    }
}
