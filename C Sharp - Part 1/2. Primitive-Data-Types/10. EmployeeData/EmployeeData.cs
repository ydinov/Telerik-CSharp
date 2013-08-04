using System;

    class EmployeeData
    {
        static void Main()
        {
            string firstName;
            string lastName;
            byte age;
            string isMale;
            ulong idNumber;
            uint employeeID = 27560000;
            byte counter = 0;
            string loop;
            string his_her = null;

            do
            {
                Console.Write("First Name: ");
                firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                lastName = Console.ReadLine();

                Console.Write("Age: ");
                age = byte.Parse(Console.ReadLine());

                if (age >= 100)
                {
                    Console.Write("Please, enter your real age: ");
                    age = byte.Parse(Console.ReadLine());
                }
                
                do
                {
                    Console.Write("Gender: ");
                    isMale = Console.ReadLine();

                    if ((isMale == "m") || (isMale == "M") || (isMale == "male") || (isMale == "Male"))
                    {
                        counter = 0;
                        his_her = "his";
                    }
                    else
                    {
                        if ((isMale == "f") || (isMale == "F") || (isMale == "female") || (isMale == "Female"))
                        {
                            counter = 0;
                            his_her = "her";
                        }
                        else
                        {
                            counter++;
                            Console.WriteLine("Please, use \"m\" for \"Male\" and \"f\" for \"Female\".");
                        }
                    }
                }
                while (counter > 0);

                Console.Write("ID Number: ");
                idNumber = ulong.Parse(Console.ReadLine());

                Console.WriteLine("Employee Number: {0}", employeeID++);

                Console.Write("Do You want to continue? [Y/N]");
                loop = Console.ReadLine();

                if ((loop == "n") || (loop == "N"))
                {
                    Console.WriteLine("\nEmployee name is {0} {1}, {2} years old. It has ID with number {3} and {4} Employee number is {5}", firstName, lastName, age, idNumber, his_her, employeeID-1);
                    //I guess, that to do the same for the cycle (e.g. to print the info for 2 or more employees) I have to store the info at some place, but as of now, I don't know how. 

                    break;
                }
            }
            while (employeeID <= 27569999);
        }
    }