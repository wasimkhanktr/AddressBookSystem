using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class FileIO
    {
        string filepath = @"C:\Users\wasimkhanktr\Desktop\BridgeLabs\.net\assigment\AddressBookSystem\AddressBookSystem\TextFile1.txt";
        string path = @"C:\Users\wasimkhanktr\Desktop\BridgeLabs\.net\assigment\AddressBookSystem\AddressBookSystem\CSVFile.csv";
        string jsonPath = @"C:\Users\wasimkhanktr\Desktop\BridgeLabs\.net\assigment\AddressBookSystem\AddressBookSystem\jsonFile.json";
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
        public void WriteInCSVFile(Dictionary<string, List<Contact>> UserAddressBook)
        {
            using (StreamWriter writer = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                foreach (KeyValuePair<string, List<Contact>> user in UserAddressBook)
                {
                    csvWriter.WriteRecords(user.Value.ToList());
                }
            Console.WriteLine("File Written Successfully");
        }
        public void ReadInCSVFile()
        {
            using (StreamReader streamreader = new StreamReader(path))
            using (CsvReader csvReader = new CsvReader(streamreader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<Contact>().ToList();
                foreach (Contact contact in records)
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
        public void WriteInJsonFile(Dictionary<string, List<Contact>> UserAddressBook)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (var write = new StreamWriter(jsonPath))
            using (JsonWriter writer = new JsonTextWriter(write))
            {
                jsonSerializer.Serialize(writer, UserAddressBook);
            }
            Console.WriteLine("File Written Successfully");
        }

    }
}