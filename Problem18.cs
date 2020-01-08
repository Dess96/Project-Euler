//By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.
//That is, 3 + 7 + 4 + 9 = 23.
//Find the maximum total from top to bottom of the triangle below
using System;

namespace Euler
{
    public class Triangle
    {
        private int rows = 15;
        private int columns = 29;
        private int[,] triangle = new int [15, 29] {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 95, 0, 64, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 17, 0, 47, 0, 82, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 18, 0, 35, 0, 87, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 0, 4, 0, 82, 0, 47, 0, 65, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 19, 0, 1, 0, 23, 0, 75, 0, 3, 0, 34, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 88, 0, 2, 0, 77, 0, 73, 0, 7, 0, 63, 0, 67, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 99, 0, 65, 0, 4, 0, 28, 0, 6, 0, 16, 0, 70, 0, 92, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 41, 0, 41, 0, 26, 0, 56, 0, 83, 0, 40, 0, 80, 0, 70, 0, 33, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 41, 0, 48, 0, 72, 0, 33, 0, 47, 0, 32, 0, 37, 0, 16, 0, 94, 0, 29, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 53, 0, 71, 0, 44, 0, 65, 0, 25, 0, 43, 0, 91, 0, 52, 0, 97, 0, 51, 0, 14, 0, 0, 0, 0},
                                                    {0, 0, 0, 70, 0, 11, 0, 33, 0, 28, 0, 77, 0, 73, 0, 17, 0, 78, 0, 39, 0, 68, 0, 17, 0, 57, 0, 0, 0},
                                                    {0, 0, 91, 0, 71, 0, 52, 0, 38, 0, 17, 0, 14, 0, 91, 0, 43, 0, 58, 0, 50, 0, 27, 0, 29, 0, 48, 0, 0},
                                                    {0, 63, 0, 66, 0, 4, 0, 68, 0, 89, 0, 53, 0, 67, 0, 30, 0, 73, 0, 16, 0, 69, 0, 87, 0, 40, 0, 31, 0},
                                                    {4, 0, 62, 0, 98, 0, 27, 0, 23, 0, 9, 0, 70, 0, 98, 0, 73, 0, 93, 0, 38, 0, 53, 0, 60, 0, 4, 0, 23}};

        //used to store the sum of the numbers in each level
        private int[,] aux = new int [15, 29]       {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
        
        ///<param name="i"> Indicates the position in the rows </param>
        ///<param name="j"> Indicates the position in the columns </param>

        public void sumNeighbor(int i, int j)
        {
            if(i+1 < rows)
            {
                if(j-1 >= 0)
                {
                    if(aux[i, j] + triangle[i+1, j-1] > aux[i+1, j-1]) //as there are different routes to the same position, only use the highest number
                    {
                        aux[i+1, j-1] = aux[i, j] + triangle[i+1, j-1];
                    }
                    sumNeighbor(i+1, j-1); //left diagonal
                }
                if(j+1 < columns)
                {
                    if(aux[i, j] + triangle[i+1, j+1] > aux[i+1, j+1]) //as there are different routes to the same position, only use the highest number
                    {
                        aux[i+1, j+1] = aux[i, j] + triangle[i+1, j+1];
                    }
                    sumNeighbor(i+1, j+1); //right diagonal
                }
            }
        }

        ///<returns> Return the highest number in the sums of the triangle </returns>

        public int getNumber()
        {
            int higherNumber = 0;
            for(int i=0; i < columns; i++) //only check last row because it has the sum of the other numbers
            {
                if(aux[rows - 1, i] > higherNumber)
                {
                    higherNumber = aux[rows - 1, i];
                }
            }
            return higherNumber;
        }

        public void print()
        {
            int result;
            sumNeighbor(0, 14);
            result = getNumber();
            Console.WriteLine("The maximum total from top to bottom in the triangle is {0}", result);
        }
    }
}

 

