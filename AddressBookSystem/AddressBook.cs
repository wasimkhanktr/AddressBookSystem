using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<Contact> contacts = new List<Contact>();
        public void AddContact(string firstName, string lastName, string address, string city, string state, string zipCode, string email, string phoneNo)
        {
            contacts.Add(new Contact()
            {
                firstName = firstName,
                lastName = lastName,
                address = address,
                city = city,
                state = state,
                zipCode = zipCode,
                email = email,
                phoneNo = phoneNo
            });
            Console.WriteLine("Contacts of " + firstName + " has been added.");
        }
    }
}