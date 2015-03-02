using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {


            ChangeAmount(3.18m);
            ChangeAmount(0.99m);
            ChangeAmount(12.93m);


            Console.ReadKey();
        }

        
        /// <summary>
        /// takes input and calculates how much change and bills are needed 
        /// </summary>
        /// <param name="amount">decimal amount</param>
        /// <returns>change or bills depending on amount</returns>
        public static Change ChangeAmount(decimal amount)
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();

            //TODO: Fill in the code to make this function work

            //original amount
            Console.WriteLine("Amount: " + "$" + amount);

            decimal amount1 = amount;
            while (amount1 > 0)
            {
                
                if (amount1 >= 100.00m)
                {
                    amount1 -= 100.00m;
                    amountAsChange.Hundreds++;
                }
                else if (amount1 >= 50.00m)
                {
                    amount1 -=50.00m;
                    amountAsChange.Fifties++;
                }
                else if (amount1 >= 20.00m)
                {
                    amount1 -= 20.00m;
                    amountAsChange.Twenties++;
                }
                else if (amount1 >= 10.00m)
                {
                    amount1 -= 10.00m;
                    amountAsChange.Tens++;
                }
                else if (amount1 >= 1.00m)
                {
                    amount1 -= 1.00m;
                    amountAsChange.Ones++;
                }
                else if (amount1 >= 00.25m)
                {
                    amount1 -= 0.25m;
                    amountAsChange.Quarters++;
                }
                else if (amount1 >= 00.10m)
                {
                    amount1 -= 0.10m;
                    amountAsChange.Dimes++;
                }
                else if (amount1 >= 00.05m)
                {
                    amount1 -= 0.05m;
                    amountAsChange.Nickels++;
                }
                else 
                {
                    amount1 -= 0.01m;
                    amountAsChange.Pennies++;
                }            
            }

            //since function automatically adds a penny after the end of the loop, subtract a penny
            Console.WriteLine("100's : " + amountAsChange.Hundreds);
            Console.WriteLine("50's: " + amountAsChange.Fifties);
            Console.WriteLine("20's: " + amountAsChange.Twenties);
            Console.WriteLine("10's: " + amountAsChange.Tens);
            Console.WriteLine("1's: " + amountAsChange.Ones);
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);
            Console.WriteLine("Dimes: " + amountAsChange.Dimes);
            Console.WriteLine("Nickels: " + amountAsChange.Nickels);
            Console.WriteLine("Pennies: " + amountAsChange.Pennies + "\n");


                //return our Change Object
                return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        public int Hundreds { get; set; }
        public int Fifties { get; set; }
        public int Twenties { get; set; }
        public int Tens { get; set; }
        public int Fives { get; set; }
        public int Ones { get; set; }


        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickels { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickels = 0;
            this.Pennies = 0;
        } 
    }
}