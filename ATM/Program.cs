using System;

namespace ATM
{
    class Program
    {
        static  void Main(string[] args)
        {
            int amount = 2034, deposit, withdraw;
            int choice, pin = 0, x = 0;
            Console.WriteLine("Enter You Four Digit Pin");
            pin = int.Parse(Console.ReadLine());
            if (pin.ToString().Length != 4)
                Console.WriteLine("PIN MUST BE A FOUR DIGIT NUMBER");
            else
            {

                Console.WriteLine("welcome To Co-oparative Bank Services \n");
                Console.WriteLine("*********************************************\n\n");
                Console.WriteLine("1. CHECK BALANCE \n");
                Console.WriteLine("2. WITHDRAL\n");
                Console.WriteLine("3. DEPOSIT \n");
                Console.WriteLine("4. CANCEL \n");
                Console.WriteLine("*********************************************\n");
                Console.WriteLine("ENTER YOUR CHOICE \n");
              
                choice = int.Parse(Console.ReadLine());
                switch (choice )
                {
                    case 1:
                        Console.WriteLine(" \n YOUR CURRENT BALANCE IS Rs :{0} ", amount);
                        break;

                    case 2:
                        Console.WriteLine("\n ENTER WITHDRAWAL AMOUNT");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 1000 != 0)
                        {
                            Console.WriteLine("PLEASE ENTER AMOUNT ABOVE 1000");
                        }
                        else if (withdraw > (amount - withdraw))
                        {
                            Console.WriteLine("INSUFFICIENT BALANCE");
                        }else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("*********************************************\n");
                            Console.WriteLine("PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("*********************************************\n");
                            Console.WriteLine("YOUR CURRENT BALANCE IS Rs :{0}", amount);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("ENTER THE AMOUNT TO DEPOSIT");
                            Console.WriteLine("*********************************************\n");
                            deposit = int.Parse(Console.ReadLine());
                            amount = deposit + amount;
                            Console.WriteLine("*********************************************\n");
                            Console.WriteLine("CASH WAS SUCCESSFULLY DEPOSITED");
                            Console.WriteLine("*********************************************\n");
                            Console.WriteLine("YOUR NEW BALANCE IS Rs : {0}", amount);
                            Console.WriteLine("*********************************************\n");
                        }
                       
                        break;
                    case 4:
                        {
                            Console.WriteLine("THANK YOU");
                        }
                       
                        break;
                     default:
                        {
                            Console.WriteLine("INVALID CHOICE");
                        }
                      
                        break; 

                }

            }
        
            Console.WriteLine("THANK YOU FOR CHOOSING CO-OPERATIVE BANK");
        }
    }
}
