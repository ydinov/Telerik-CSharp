using System;

class AgeIn10Years
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("How old are you?");
                string CurrAge = Console.ReadLine();
                if ((CurrAge == "n") || (CurrAge == "N") || (CurrAge == "No") || (CurrAge == "no") || (CurrAge == "exit"))
                {
                    break;
                }
                int a = Convert.ToInt32(CurrAge);
                int CurrYear = DateTime.Now.Year;
                Console.WriteLine("You will be {0} years old in {1}.", a +10 , CurrYear +10);
                Console.WriteLine("Do you want to try again? [Y/N]");
                string Cont = Console.ReadLine();
                if ((Cont == "n") || (Cont == "N") || (Cont == "No") || (Cont == "no") || (Cont == "exit"))
                {
                    break;
                }
                else
                {
                    if ((Cont == "y") || (Cont == "Y") || (Cont == "Yes") || (Cont == "YES") || (Cont == "yes") || (Cont == "exit"))
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please, enter your age as whole number!");
            }
        }
    }
}
