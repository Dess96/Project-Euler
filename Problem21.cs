//Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
//If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
//Evaluate the sum of all the amicable numbers under 10000.
using System;

namespace Euler
{
    public class Amicable
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

        ///<returns> Returns the sum of amicable numbers under 10000 </returns>

        public int getAmicable()
        {
            int i = 220; //The first amicable number is 220
            int sum = 0;
            int res, res2;
            while(i < 10000)
            {
                res = getDivisors(i);
                res2 = getDivisors(res);
                if(i == res2 && res != res2) //The second condition is to avoid getting numbers like 6 and 28 as amicable numbers
                {
                    sum += i;
                }
                ++i;
            }
            return sum;
        }

        public void print()
        {
            int result;
            result = getAmicable();
            Console.WriteLine("The sum of all amicable numbers under 10000 is {0}", result);
        }
    }
}