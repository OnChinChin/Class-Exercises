using System;

namespace AIE_25_SaveContact
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact person1 = new Contact("bob", "bob@email.com", "12345678");
            Contact person2 = new Contact("fred", "fred@email.com", "12345678");
            Contact person3 = new Contact("ted", "ted@email.com", "12345678");

            // write each contact to file
            person1.Serialise("./bob.txt");
            person2.Serialise("./fred.txt");
            person3.Serialise("./ted.txt");


            // lets clear out the "contact" and load it back in from file
            person1 = new Contact();
            person2 = new Contact();
            person3 = new Contact();

            person1.DeSerialise("./bob.txt");
            person2.DeSerialise("./fred.txt");
            person3.DeSerialise("./ted.txt");

            person1.Print();
            person2.Print();
            person3.Print();
        }
    }

}
