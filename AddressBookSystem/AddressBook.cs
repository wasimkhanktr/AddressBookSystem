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
        public void edit(string Name)
        {
            Contact editContact = new Contact();
            foreach (Contact val in contacts)
            {
                if (val.firstName == Name)
                {
                    editContact = val;
                    contacts.Remove(val);
                    break;
                }
            }
            Console.WriteLine("Enter 1 to change the firstname");
            Console.WriteLine("Enter 2 to change the lastname");
            Console.WriteLine("Enter 3 to change the address");
            Console.WriteLine("Enter 4 to change the city");
            Console.WriteLine("Enter 5 to change the state");
            Console.WriteLine("Enter 6 to change the zipcode");
            Console.WriteLine("Enter 7 to change the email");
            Console.WriteLine("Enter 8 to change the phoneNo");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter new Firstname");
                    editContact.firstName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter new lastname");
                    editContact.lastName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter new address ");
                    editContact.address = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Enter new city");
                    editContact.city = Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Enter new state");
                    editContact.state = Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Enter new zipcode");
                    editContact.zipCode = Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Enter new email");
                    editContact.email = Console.ReadLine();
                    break;
                case 8:
                    Console.WriteLine("Enter new PhoneNo");
                    editContact.phoneNo = Console.ReadLine();
                    break;
            }
            contacts.Add(editContact);
            Console.WriteLine("Data Updated Successfully");
        }
        public void display()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine("FirstName: " + contact.firstName);
                Console.WriteLine("LastName: " + contact.lastName);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("zipCode: " + contact.zipCode);
                Console.WriteLine("Email: " + contact.email);
                Console.WriteLine("PhoneNo: " + contact.phoneNo);
            }
        }
        public void delete(string name)
        {
            foreach (Contact val in contacts)
            {
                if (val.firstName == name)
                {
                    contacts.Remove(val);
                    break;
                }
            }
            Console.WriteLine("Deleted Successfully");
        }
        public void addressBook()
        {
            int exit = 0;
            Console.WriteLine("Welcome to Address Book System");
            while (true)
            {
                Console.WriteLine("Enter 1 to add new Contact");
                Console.WriteLine("Enter 2 to edit the Contact");
                Console.WriteLine("Enter 3 to display adress book");
                Console.WriteLine("Enter 4 to delete a contact");
                Console.WriteLine("Enter 5 to exit");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter the firstName");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter the lastName");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter the address");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter the city");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter the state");
                        string state = Console.ReadLine();
                        Console.WriteLine("Enter the email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter the PhoneNo");
                        string phoneNo = Console.ReadLine();
                        Console.WriteLine("Enter the Zipcode");
                        string zip = Console.ReadLine();
                        AddContact(firstName, lastName, address, city, state, zip, email, phoneNo);
                        break;
                    case 2:
                        Console.WriteLine("Enter the firstName");
                        string Name = Console.ReadLine();
                        edit(Name);
                        break;
                    case 3:
                        display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the firstName");
                        string name = Console.ReadLine();
                        delete(name);
                        break;
                    case 5:
                        exit = 1;
                        break;
                }
                if (exit == 1)
                    break;
            }
        }
    }
}