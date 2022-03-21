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
        public int Zip_Code =0;
        public int Phone_Number = 1;
        public string Email = "";

        public ContactsDetails(string First_Name, string Last_Name, string Address, string City, string State, int Zip_Code, int Phone_Number, string Email)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip_Code = Zip_Code;
            this.Phone_Number = Phone_Number;
            this.Email = Email;
        }
        public string tostring()
        {
            return "Details of " + First_Name + "  " + Last_Name + " are : " + " Address: " + Address + "City:" + City + "\n" 
                                 +"                                  "+        " state - " + State + " Zip_Code -" + Zip_Code + "\n" 
                                 +"                                  "+        " phone number -" + Phone_Number + "\n" 
                                 +"                                 "+        "Email :" + Email;

        }



    }


    class program
    {
        private ArrayList ContactDetailsList;
        private Dictionary<string, ContactsDetails> ContactDetailsMap;
        public program()
        {
            ContactDetailsList = new ArrayList();
            ContactDetailsMap = new Dictionary<string, ContactsDetails>();
        }



        
        public void AddDetails(string First_Name, string Last_Name, string Address, string City, string State, int zip_code,int phone_number, string Email)
        {
            ContactsDetails contactsDetails = new ContactsDetails(First_Name, Last_Name, Address, City, State, zip_code, phone_number, Email);
            ContactDetailsList.Add(contactsDetails);
            ContactDetailsMap.Add(First_Name, contactsDetails);
        }
        public void ComputeDetails()
        {
            foreach (ContactsDetails contact in ContactDetailsList)
            {
                Console.WriteLine(contact.tostring());

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Addressbook");
            program details = new program();

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

            details.AddDetails(First_Name, Last_Name, Address, City, State, Zip_Code, Phone_Number, Email);

            details.ComputeDetails();









        }

    }
}













