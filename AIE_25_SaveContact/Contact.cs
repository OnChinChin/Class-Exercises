using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AIE_25_SaveContact
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


        public void Serialise(string filename)
        {
            // TODO: use StreamWriter to write the name, email and phone to file

            // Create a file to write to.
            var fileInfo = new FileInfo(filename);
            Directory.CreateDirectory(fileInfo.Directory.FullName);

            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine(name);
                sw.WriteLine(email);
                sw.WriteLine(phone);
            }
            

        }

        public void DeSerialise(string filename)
        { 
            // TODO: use StreamReader to write the name, email and phone to file
            using (StreamReader sr = File.OpenText(filename))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }
    }
}
