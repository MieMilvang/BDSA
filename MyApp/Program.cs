using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isnset the year you want to check if is leap year here and press Enter: ");
            var insertedValue = Console.ReadLine(); 
            bool isParsed = false;
            
            while (!isParsed)
            {
                int year;
                isParsed = Int32.TryParse(insertedValue, out year); 
                if (isParsed){
                    isLeapYear(year);
                }
            }
           
        
            //Console.WriteLine("Hello World!");
            
        }

        public static bool isLeapYear(int year) //return (year%4=0 and (year%100!=0 or year%400=0)
        {
            
            if(year%100==0 && year%400==0)
                {
                    Console.WriteLine("yay");
                    return true;
                }
            else if (year%100==0 && year%400!=0)
                {
                    Console.WriteLine("nay");
                    return false;
                }
            else if (year%4==0) 
                {
                    Console.WriteLine("yay");
                    return true;
                }
            Console.WriteLine("nay");
            return false;
            }
        }
    }

