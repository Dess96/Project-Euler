//n! means n × (n − 1) × ... × 3 × 2 × 1
//For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
//and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
//Find the sum of the digits in the number 100!

//getFactorial and multiply retrieved from https://www.geeksforgeeks.org/factorial-large-number/
using System;

namespace Euler
{
    public class Factorial
    {
        ///<param name="number"> Indicates the number to get the factorial </param>
        ///<returns> Returns the sum of the digits of the factorial </returns>

        public int getFactorial(int number) 
        { 
            int []result = new int[200]; //Stores each digit of the result
            int res_size = 1; //Size of the array
            int sum;
    
            result[0] = 1; //1! = 1
    
            for (int i = 2; i <= number; i++)
            {
                res_size = multiply(i, result, res_size); 
            }
            sum = getSum(result, res_size);
            return sum;
        } 
        
        ///<param name="x"> Indicates the multiplier </param>
        ///<param name="result"> Indicates the array that has the digits </param>
        ///<param name="res_size"> Indicates the current size of the array result </param>
        ///<returns> Returns the size of the array </returns>

        public int multiply(int x, int []result, int res_size) 
        { 
            int carry = 0; 
            for (int i = 0; i < res_size; i++) 
            { 
                int prod = result[i] * x + carry; //multiply each digit by x and add the carry
                result[i] = prod % 10; //take the remainder to get the digit without the carry
                carry = prod / 10; //divide to get the carry
            } 
            while (carry != 0) //check if we need to increase the size of the number
            { 
                result[res_size] = carry % 10; //add the rest of the carry
                carry = carry / 10; 
                res_size++; 
            } 
            return res_size; 
        }        

        ///<param name="result"> Indicates the array that has the digits of the factorial </param>
        ///<param name="res_size"> Indicates the size of the array result </param>
        ///<returns> Returns the sum of the digits of the array result </returns>

        public int getSum(int[] result, int res_size)
        {
            int sum = 0;
            for(int i=0; i < res_size; i++)
            {
                sum += result[i];
            }
            return sum;
        }

        public void print()
        {
            int sum;
            sum = getFactorial(100);
            Console.WriteLine("The sum of the digits of 100! is {0}", sum);
        }
    }
}