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
            MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
            multipleAddressBook.MultipleBook();
            multipleAddressBook.Display();
            multipleAddressBook.SearchPersonInCityOrState();
            multipleAddressBook.ViewPersonInCityOrState();
            multipleAddressBook.CountByCityOrState();
            multipleAddressBook.SortPersonName();
            multipleAddressBook.WriteFile();
            multipleAddressBook.ReadFile();
            multipleAddressBook.WriteInCSVFile();
            multipleAddressBook.ReadInCSVFile();
        }
    }
}