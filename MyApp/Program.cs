using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insert the year you want to check if is leap year here and press Enter: ");

            var insertedValue = Console.ReadLine(); 

            try{
                int year = int.Parse(insertedValue); 
                if(isLeapYear(year)){
                    Console.WriteLine("yay");
                }
                else 
                    Console.WriteLine("nay");

            }
            catch(ArgumentException e){
                Console.WriteLine(e.Message);
            }
            catch(FormatException e) {
                Console.WriteLine(e.Message);
            }
        }

        public static bool isLeapYear(int year) //return (year%4=0 and (year%100!=0 or year%400=0)
        {

            if(year < 1582) {
                throw new ArgumentException("the year must be 1582 or after");
            }
            if(year%100==0 && year%400==0)
                {
                    return true;
                }
            else if (year%100==0 && year%400!=0)
                {
                    return false;
                }
            else if (year%4==0) 
                {
                    return true;
                }
            return false;
        }
    }
}
