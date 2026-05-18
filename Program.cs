using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.Transactions;

namespace consolebankingapplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOC");
            Console.WriteLine("--------------");
            Console.WriteLine("welcome to BOC");
             Console.WriteLine("--------------");

            Console.ReadKey();

            string bankname = "bankof ceylon";
            string accountholdername = "Kugathas sujev";
            int accountnumber = 12345678;
            double accountbalance = 15000;

            Console.WriteLine("accountholdername" + " " + accountholdername);
            Console.WriteLine("accountnumber" + " " + accountnumber);
            Console.WriteLine("accountbalance" + " " + accountbalance);

            Console.WriteLine("enter your name");
            Console.ReadLine();

            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("hello" + name);

            Console.Write("hello" + " " + name);

            Console.Write("enter your opening balance");
            double openingbalance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("bankname:" + " " + bankname);
            Console.WriteLine("accountholdername" + " " + accountholdername);
            Console.WriteLine("accountnumber" + " " + accountnumber);
            Console.WriteLine("accountbalance" + " " + accountbalance);

            Console.WriteLine(accountbalance.ToString("F2"));

            //clear the console before showing account details


            /* accountbalance details
             account balance
             deposit
             withrawal
             exit*/







            Console.WriteLine("1.view account");
            Console.WriteLine("2.check balance");
            Console.WriteLine("3.deposit");
            Console.WriteLine("4.withrawal");
            Console.WriteLine("5.exit");

            Console.WriteLine("enter an option");

            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("Account Details");
                Console.WriteLine("bankname:" + " " + bankname);
                Console.WriteLine("accountholdername" + " " + accountholdername);
                Console.WriteLine("accountnumber" + " " + accountnumber);
               

            }
            else if (choice == 2)
            {
                Console.WriteLine("Balance");
                Console.WriteLine("accountbalance" + " " + accountbalance);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Deposit");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Withdraw");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Account Details");
                    Console.WriteLine("bankname:" + " " + bankname);
                    Console.WriteLine("accountholdername" + " " + accountholdername);
                    Console.WriteLine("accountnumber" + " " + accountnumber);
                    break;

                case 2:
                    Console.WriteLine("Current Balance: Rs. 50,000");
                    Console.WriteLine("accountbalance" + " " + accountbalance);
                    break;

                case 3:
                    Console.WriteLine("Enter your deposit amount");
                    double depositamount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Deposit Process Started");


                    if (depositamount > 0)
                    {
                        Console.WriteLine($"deposit completed !! \n now your balance : {accountbalance + depositamount}");

                    }
                    else
                    {
                        Console.WriteLine("depositamount is invaild");
                    }

                    break;

                case 4:
                    Console.WriteLine("enter your withrawal amount");
                    double withrawalamount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Withdrawal Process Started");

                    if (withrawalamount > 0)
                    {
                        Console.WriteLine($"withrawal completed !! \n now your balance : {accountbalance - withrawalamount}");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

          




        }
    }
}
 