//You are given the following information, but you may prefer to do some research for yourself.
//1 Jan 1900 was a Monday, Thirty days has September, April, June and November. All the rest have thirty-one, Saving February alone, Which has 
//twenty-eight, rain or shine. And on leap years, twenty-nine. A leap year occurs on any year evenly divisible by 4, but not on a century unless 
//it is divisible by 400. How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
using System;

namespace Euler
{
    public class Sundays
    {
        public int sunday1900 = 2;

        ///<param name="month"> Indicates the number of the month to count its days</param>
        ///<param name="year"> Indicates the number of the year. It is used for the method getFebruary</param>
        ///<returns> Returns the number of days a month has</returns>

        public int getMonths(int month, int year)
        {
            if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else if(month == 2)
            {
                return getFebruary(year);
            }
            else
            {
                return 31;
            }
        }

        ///<param name="year"> Indicates the number of the present year to indicate wether it is a leap year or not</param>
        ///<returns> Returns the number of days February has depending on the year</returns>

        public int getFebruary(int year)
        {
           if(year % 4 == 0)
           {
               if(year % 100 == 0)
               {
                   if(year % 400 == 0)
                   {
                       return 29;
                   }
                   else
                   {
                       return 28;
                   }
               }
               else
               {
                   return 29;      
               }
           }
           else
           {
               return 28;
           }
        }

        ///<param name="date"> Indicates the date from which we will start counting</param>
        ///<param name="month"> Indicates the month from which we will start counting</param>
        ///<param name="year"> Indicates the year from which we will start counting</param>
        ///<param name="initialDay"> Indicates the day of the week of the date parameter</param>
        ///<returns> Returns the number of sundays that fell on the first starting from a specific date</returns>

        public int countDays(int date, int month, int year, int initialDay)
        {
            int monthDays, day;
            int monthNumber = month;
            int weekDay = initialDay;
            int sundayFirst = 0;

            while(year <= 2000){
                monthNumber = 1; //counts months
                while(monthNumber <= 12)
                {
                    monthDays = getMonths(monthNumber, year);
                    day = 1; //counts days
                    while(day <= monthDays)
                    {
                        if(weekDay == 7)
                        {
                            weekDay = 0; //counts weeks
                            if(day == 1) //if it is sunday and it is first of the month
                            {
                                ++sundayFirst;
                            }
                        }
                        ++weekDay;
                        ++day;
                    }
                    ++monthNumber;
                }
                ++year;
            }           
            return sundayFirst;
        }

        public void print(){
            int yearSundayFirst;
            yearSundayFirst = countDays(1, 1, 1900, 1);
            yearSundayFirst -= sunday1900; //subtract the number of sundays of the year 1900
            Console.WriteLine("The number of Sundays that fell on the first from 1901 to 2000 is {0}", yearSundayFirst);
        }
    }
}