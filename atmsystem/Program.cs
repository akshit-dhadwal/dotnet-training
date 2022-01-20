using System;
using System.Collections;
using System.Linq;
using static Atm.Banking;

namespace Atm
{
    class Bank
    {
        static void Main(string[] args)
        {
            PersonDetail detail = new PersonDetail();
            List<Banking.Person> person = detail.GetDetail();
            
             System.Console.WriteLine("******************************Welcome to our Atm***********************************");
            System.Console.WriteLine("Enter your pin :");
            int pin = Convert.ToInt32(Console.ReadLine());
            
           foreach(Person p in person)
             {
                if(pin == p.password)
                {
                  while(true)
                 {
                     
                    System.Console.WriteLine("HELLO " + p.name);
                    System.Console.WriteLine("Choose your options :");
                    System.Console.WriteLine("1. Cash Withdrawl :");
                    System.Console.WriteLine("2. Cash Deposit :");
                    System.Console.WriteLine("3. Cancel :");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    int total = p.balance;
                    switch(choice)
                    {
                        case 1: System.Console.WriteLine("How much amount you want to withdraw :\n");
                                int amount = Convert.ToInt32(Console.ReadLine());
                                if(amount <= p.balance)
                                {
                                      System.Console.WriteLine("collect your cash please");
                                      total = total - amount;
                                      System.Console.WriteLine("your balance is : " + total);
                                      System.Console.WriteLine("******************Thank you for using this service********************");
                                }
                                else
                                {
                                     System.Console.WriteLine("you have insufficient balance in you account :");
                                }

                        break;

                        case 2: System.Console.WriteLine("How much amount you want to deposite :\n");
                                int deposit = Convert.ToInt32(Console.ReadLine());
                                total = total + deposit;
                                System.Console.WriteLine("your current balance is :" + total);
                                System.Console.WriteLine("******************Thank you for using this service********************");
                        break;

                        case 3: System.Console.WriteLine("******************Thank you for using this service********************");
                                 System.Environment.Exit(0);
                                 
                        break;

                        default: System.Console.WriteLine("Enter the valid choice");
                        break;
                    }
                  }
                }
                else
                {
                        System.Console.WriteLine("sorry you have enter wrong pin");
                }
          
            }
           


        }
        
    }
}
