using AIE_27_SaveContactList;
using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_27_SaveContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("bob", "bob@email.com", "12345678"));
            contacts.Add(new Contact("fred", "fred@email.com", "12345678"));
            contacts.Add(new Contact("ted", "", "12345678"));

            // save to file
            SerialiseContactList("contacts.txt", contacts);


            // clear them out
            contacts = new List<Contact>();

            // read from file
            DeSerialiseContactList("contacts.txt", contacts);
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine($"{contacts[i].name} {contacts[i].email} {contacts[i].phone}");
            }

        }

        static void SerialiseContactList(string filename, List<Contact> contacts)
        {
            // TODO save all contacts to file.
            if (!File.Exists(filename) || File.Exists(filename))
            {
                using (StreamWriter sw = File.CreateText(filename))
                {
                    for (int i = 0; i < contacts.Count; i++)
                    {
                        sw.WriteLine("Name: " + contacts[i].name);
                        sw.WriteLine("Email: " + contacts[i].email);
                        sw.WriteLine("Phone: " + contacts[i].phone);
                        sw.WriteLine("");
                    }
                }
            }
        }

        static void DeSerialiseContactList(string filename, List<Contact> contacts)
        {
            // TODO load all contacts from file.
            Contact contact = new Contact();
            using (StreamReader sr = File.OpenText(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        contacts.Add(contact);

                        contact = new Contact();
                    }
                    var kvp = line.Split(" ");
                    if (kvp[0] == "Name:")  contact.name  = kvp[1];
                    if (kvp[0] == "Email:") contact.email = kvp[1];
                    if (kvp[0] == "Phone:") contact.phone = kvp[1];
                }
            }
            
        }
    }
}

    
