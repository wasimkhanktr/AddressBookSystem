using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class MultipleAddressBook
    {
        Dictionary<string, List<Contact>> UserAddressBook = new Dictionary<string, List<Contact>>();
        public void MultipleBook()
        {
            Console.WriteLine("enter the no of users and addressbook");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                Console.WriteLine("enter the name of user");
                string name = Console.ReadLine();
                AddressBook addressbookob = new AddressBook();
                List<Contact> list = addressbookob.addressBook();
                UserAddressBook.Add(name, list);
                n--;
            }
        }
        public void WriteFile()
        {
            FileIO file = new FileIO();
            file.WriteUsingWriteWriter(UserAddressBook);
        }
        public void WriteInCSVFile()
        {
            FileIO file = new FileIO();
            file.WriteInCSVFile(UserAddressBook);
        }
        public void ReadFile()
        {
            FileIO file = new FileIO();
            file.ReadFile();
        }
        public void ReadInCSVFile()
        {
            FileIO file = new FileIO();
            file.ReadInCSVFile();
        }
        public void Display()
        {
            foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
            {
                Console.WriteLine("Name of Address Book Holder: " + user.Key);
                foreach (Contact contact in user.Value)
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
        }
        public void SearchPersonInCityOrState()
        {
            Console.WriteLine("enter the city or state name");
            string city = Console.ReadLine();
            int found = 0;
            foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
            {
                foreach (Contact contact in user.Value)
                {
                    if (contact.city == city || contact.state == city)
                    {
                        Console.WriteLine(contact.firstName);
                        found = 1;
                    }
                }
            }
            if (found == 0)
                Console.WriteLine("No record found");
        }
        public void ViewPersonInCityOrState()
        {
            Console.WriteLine("enter the city or state name");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
            {
                foreach (Contact contact in user.Value)
                {
                    if (contact.city == city || contact.state == city)
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
            }
        }
        public void CountByCityOrState()
        {
            int count = 0;
            Console.WriteLine("enter the city or state name");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
            {
                count += user.Value.Count(x => x.city == city || x.state == city);
            }
            Console.WriteLine("No of persons in city " + city + " is " + count);
        }
        public void SortPersonName()
        {
            Console.WriteLine("Enter 1 to sort firstName");
            Console.WriteLine("Enter 2 to sort City");
            Console.WriteLine("Enter 3 to sort state");
            Console.WriteLine("Enter 4 to sort zip");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
                {
                    user.Value.Sort((emp1, emp2) => emp1.firstName.CompareTo(emp2.firstName));
                }
            }
            if (choice == 2)
            {
                foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
                {
                    user.Value.Sort((emp1, emp2) => emp1.city.CompareTo(emp2.city));
                }
            }

            if (choice == 3)
            {
                foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
                {
                    user.Value.Sort((emp1, emp2) => emp1.state.CompareTo(emp2.state));
                }
            }

            if (choice == 4)
            {
                foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
                {
                    user.Value.Sort((emp1, emp2) => emp1.zipCode.CompareTo(emp2.zipCode));
                }
            }

            Display();
        }
    }
}