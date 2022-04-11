using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class FileIO
    {
        string filepath = @"C:\Users\wasimkhanktr\Desktop\BridgeLabs\.net\assigment\AddressBookSystem\AddressBookSystem\TextFile1.txt";
        public void WriteUsingWriteWriter(Dictionary<string, List<Contact>> UserAddressBook)
        {
            foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
            {
                using (StreamWriter sr = File.AppendText(filepath))
                {
                    sr.WriteLine("Name of User" + user.Key);
                    foreach (Contact contact in user.Value)
                    {
                        sr.WriteLine("FirstName: " + contact.firstName);
                        sr.WriteLine("LastName: " + contact.lastName);
                        sr.WriteLine("City: " + contact.city);
                        sr.WriteLine("State: " + contact.state);
                        sr.WriteLine("Address: " + contact.address);
                        sr.WriteLine("zipCode: " + contact.zipCode);
                        sr.WriteLine("Email: " + contact.email);
                        sr.WriteLine("PhoneNo: " + contact.phoneNo);
                    }
                }
            }
            Console.WriteLine("File Written Successfully");
        }
        public void ReadFile()
        {
            string lines = File.ReadAllText(filepath);
            Console.WriteLine(lines);
            Console.WriteLine("File Read Successfully");
        }

    }
}