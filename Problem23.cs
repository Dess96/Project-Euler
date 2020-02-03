//A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
//As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. 
//By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this 
//upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of 
//two abundant numbers is less than this limit.
//Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
using System;
using System.Collections.Generic;

namespace Euler
{
    public class Abundant
    {
        ///<param name="n"> Indicates the number from which we will get the sum of its divisors </param>
        ///<returns> Returns the sum of the divisors of the parameters </returns>

        public int getDivisors(int n)
        {
            int i = 2;
            int sum = 0;
            while(i <= Math.Sqrt(n)) //Since divisors come in pairs, we can stop at the square root of n
            {
                if(n % i == 0) 
                {
                    if (n / i == i) //Do not repeat the same divisor twice
                    {
                        sum += i;
                    }                  
                    else
                    {
                        sum += i + n / i;
                    } 
                }
                ++i;
            }
            ++sum;
            return sum;
        }

        ///<returns> Returns the final sum of the numbers that can be expressed as the sum of two abundant numbers </returns>

        public int findAbundant()
        {
            IList<int> abundants = new List<int>(); //A list that will contain abundant numbers
            int sum;
            int i = 12; //The problem states that the smallest abundant number is 12
            int res;
            while(i <= 28110) //Highest number with a sum lower than 28123 
            {
                sum = getDivisors(i);
                if(sum > i) //If the sum of divisors is higher than the number, that number is abundant and is added to the list
                {
                    abundants.Add(i);
                }
                ++i;
            }
            res = finalSum(abundants);
            return res;
        }

        ///<param name="abundants"> Contains a list with abundant numbers </param>
        ///<returns> Returns a list with every possible sum of two abundant numbers without repeating numbers or surpassing 28123 </returns>

        public IList<int> findAbundantSum(IList<int> abundants)
        {
            IList<int> sums = new List<int>(); //A list that will contain the sums of all pairs of abundant numbers
            for(int i = 0; i < abundants.Count; i++)
            {
                for(int j = i; j < abundants.Count; j++)
                {
                    if(abundants[i] + abundants[j] <= 28123 && !(sums.Contains(abundants[i] + abundants[j]))) //The problem states that every number
                    //higher than 28123 can be written as the sum of two abundant numbers. Therefore, we don't need to check higher than that.
                    //The contains method ensure that we are not repeating numbers on the list.
                    {
                        sums.Add(abundants[i] + abundants[j]);
                    }
                }
            }
            return sums;
        }

        ///<param name="abundants"> Contains a list with abundant numbers </param>
        ///<returns> The sum of all positive integers that cannot be written as the sum of two abundant numbers </returns>

        public int finalSum(IList<int> abundants)
        {
            IList<int> sums;
            int fSum = 276; //We know that numbers from 1-23 cannot be written as the sum of two abundant numbers since the smallest sum is 24
            int i = 24;
            while(i <= 28123) //We are not interested in numbers higher than 28123 as stated before
            {
                fSum += i;
                ++i;
            }
            sums = findAbundantSum(abundants);
            for(int j = 0; j < sums.Count; j++)
            {
                fSum -= sums[j]; //We subtract each number that can be expressed as the sum of two abundants
            }
            return fSum;
        }


        public void print()
        {
            int finalRes;
            finalRes = findAbundant();
            Console.WriteLine("The sum of all positive integers that cannot be written as the sum of two abundant numbers is {0}", finalRes);
        }
    }
}