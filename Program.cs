using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Topic_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string programRun;
            Console.WriteLine("Welcome To Decision Structures");
            Console.WriteLine("Would you Like to Run SBM, PGC, or Hurricane");
            programRun = Console.ReadLine().ToLower();
            if (programRun == "sbm")
            {
                Console.Clear();
                SBM();
            }
            else if (programRun == "pgc")
            {
                Console.Clear();
                PGC();
            }
            else if (programRun == "hurricane")
            {
                Console.Clear();
                Hurricane();
            }
            Console.Clear();

        }

        private static void SBM() //Simple Banking Machine
        {
            int blorbDollar = 150;
            string transaction;
            int depositFund;
            int withdrawFund;
            int billPay;

            Console.Write($"Welcome to the Bank Of Blorb, You Currently Have {blorbDollar} BLD(Blorbian Dollars)");
            Thread.Sleep(500);
            Console.WriteLine("This Session will cost you 0.75 BLD (BoB is not responsible for Blorbian Errors resulting in multiple paid sessions)");
            Thread.Sleep(500);
            Console.WriteLine("Would you like to make a Deposit, Withrawal, Bill Payment, or Account Balance Update?");
            transaction = Console.ReadLine().ToLower();
            if (transaction == "deposit")
            {
                Console.WriteLine($"How much would you like to deposit?");
                depositFund = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your new Total is {(blorbDollar + depositFund) - 0.75}");

            }
            else if (transaction == "withdrawal")
            {
                Console.WriteLine($"How much would you like to withrawal");
                withdrawFund = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You have Withdrawed {withdrawFund} your new balance is {blorbDollar - withdrawFund - 0.75}");
            }
            else if (transaction == "bill payment")
            {
                Console.WriteLine($"You have an outstanding bill. How much would you like to pay?");
                billPay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your payment was registered, your new balance is {blorbDollar - billPay - 0.75}");
            }
            else if (transaction == "account balance update")
            {
                Console.WriteLine($"Account Balance Update registered. Your new Balance is {blorbDollar - 0.75}");
            }
            else 
            {
                Console.WriteLine($"Error Detected, Updating Account, New Balance {blorbDollar - 0.75}");
            }


        }

        private static void PGC() //Parking Garage Cost
        {
            
            double parkStart;
            double parkEnd;
            double parkCost;
            

            Console.WriteLine("Welcome to Sam's Parking Garage, Please use a 24 hour clock.");
            Console.WriteLine("Please Enter The Current Time.");
            parkStart = Convert.ToDouble(Console.ReadLine());
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Some hours later.....");
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Welcome Back to Sam's Parking Garage");
            Console.WriteLine("Please Enter The Current Time");
            parkEnd = Convert.ToDouble(Console.ReadLine());
            parkCost = (parkEnd - parkStart) * 2 + 4;
            if (parkCost > 20)
            {
                parkCost = 20;
                Console.WriteLine($"Your Parking bill is {parkCost}$") ;
            }
            if (parkCost < 0)
            {
                parkCost = 4;
                Console.WriteLine($"Your Parking bill is {parkCost}$");
            }
            else
            {
                Console.WriteLine($"Your Parking bill is {(parkEnd - parkStart) * 2 + 4}$");
            }
            Console.ReadLine();
        }

        private static void Hurricane() //Hurricane
        {
            string funFact;
            double hCategory;

            Console.WriteLine("Welcome to the Saffir-Simpson Hurricane Scale.");
            Console.WriteLine();
            Console.WriteLine("Please Enter a Category of Hurricane");
            Console.WriteLine("For the Information of the Hurricane Category it Falls Into.");
            hCategory = Convert.ToDouble(Console.ReadLine());

            switch (hCategory)
            {
                default:
                    Console.WriteLine("Not A Valid Response");
                    Console.WriteLine("Please Enter a Category") ;
                    break;

                case 1:
                    Console.WriteLine("A Category One Hurricane has Wind Speeds of 74-95 mph or 64-82 kt or 119-153 km/hr");
                    Console.WriteLine("Very dangerous winds will produce some damage");
                    break;

                case 2:
                    Console.WriteLine("A Category Two Hurricane has Wind Speeds of 96-110 mph or 83-95 kt or 154-177 km/hr");
                    Console.WriteLine("Extremely dangerous winds will cause extensive damage");
                    break;

                case 3:
                    Console.WriteLine("A Category Three Hurricane has Winds 111-129 mph or 96-112 kt or 178-208 km/hr");
                    Console.WriteLine("Devastating damage will occur");
                    break;

                case 4:
                    Console.WriteLine("A Category Four Hurricane has Winds 130-156 mph or 113-136 kt or 209-251 km/hr");
                    Console.WriteLine("Catastrophic damage will occur");
                    break;

                case 5:
                    Console.WriteLine("A Category Five Hurricane has Winds 157 mph or higher or 137 kt or higher or 252 km/hr or higher");
                    Console.WriteLine("Even More Catastrophic damage will occur");
                    break;

            }

            Console.WriteLine();
            Console.WriteLine("Would you like a fun fact?");
            funFact = Console.ReadLine().ToLower();

            if (funFact == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("Tornadoes, Hurricanes, Typhoons, and Cyclones are techically the same");
                Console.WriteLine("as Tornadoes are land based, whilst Hurricanes, Cyclones, and Typhoons are the same");
                Console.WriteLine("except for where they happen they have different names");
            }
            else if (funFact == "no") 
            {
                Console.WriteLine();
                Console.WriteLine(":c");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("..............");
            }
            Console.ReadLine();

        }

    }
}
