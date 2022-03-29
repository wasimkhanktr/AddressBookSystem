using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exit = 0;
            Console.WriteLine("Welcome to Address Book System");
            while (true)
            {
                Console.WriteLine("Enter 1 to add new Contact");
                Console.WriteLine("Enter 2 to exit");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        AddressBook addressBook = new AddressBook();
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
                        addressBook.AddContact(firstName, lastName, address, city, state, zip, email, phoneNo);
                        break;
                    case 2:
                        exit = 1;
                        break;
                }
                if (exit == 1)
                    break;
            }
        }
    }
}