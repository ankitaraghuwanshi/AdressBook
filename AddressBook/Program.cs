using System;
using System.Collections;

namespace AddressBook
{
    class ContactsDetails
    {
        public string First_Name = "";
        public string Last_Name = "";
        public string Address = "";
        public string City = "";
        public string State = "";
        public string Zip_Code = "";
        public string Phone_Number = "";
        public string Email = "";

        public ContactsDetails()
        {
            Console.WriteLine("Enter First_Name");
            string First_Name = Console.ReadLine();

            Console.WriteLine("Enter Last_Name");
            string Last_Name = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string Address = Console.ReadLine();

            Console.WriteLine("Enter City");
            string City = Console.ReadLine();

            Console.WriteLine("Enter State");
            string State = Console.ReadLine();

            Console.WriteLine("Enter Zip_Code");
            int Zip_Code = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter Phone_Number");
            int Phone_Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Email");
            string Email = Console.ReadLine();

        }
        class AddressBook
        {
            public static void Main(string[] agrs)
            {
                Console.WriteLine("Welcome to Address Book System");
                ContactsDetails Book = new ContactsDetails();
            }
        }
    }

}         
                
             

        








    


















