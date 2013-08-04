//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter company phone number: ");
        int companyPhone = int.Parse(Console.ReadLine());

        Console.Write("Enter company fax number: ");
        int companyFax = int.Parse(Console.ReadLine());

        Console.Write("Enter company web site: ");
        string companyWeb = Console.ReadLine();

        Console.Write("Enter company manager: ");
        string[] manager = Console.ReadLine().Split();

        string managerFirstName = manager[0];
        string managerLastName = manager[1];
        
        Console.Write("Enter manager age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Enter manager phone number: ");
        int managerPhone = int.Parse(Console.ReadLine());

        Console.WriteLine("\nCompany: {0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Phone number: (+359 {0:0)000-00-00}", companyPhone);
        Console.WriteLine("Fax number: (+359 {0:0)000-00-00}", companyFax);
        Console.WriteLine("Web site: {0}", companyWeb);
        Console.WriteLine("\nManager's first name: {0}", managerFirstName);
        Console.WriteLine("Manager's last name: {0}", managerLastName);
        Console.WriteLine("Age: {0}", managerAge);
        Console.WriteLine("Phone number: {0:0000-000-000}", managerPhone);
    }
}