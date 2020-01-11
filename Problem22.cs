//Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into 
//alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to 
//obtain a name score.
//What is the total of all the name scores in the file?
using System;
using System.IO;

namespace Euler
{
    public class Names
    {
        ///<returns> Returns an array with each name in the file </returns>

        public string[] readTxt()
        {
            string file = @"C:\Users\d3n1s\Downloads\p022_names.txt";
            string[] separated = new string[] { };
            if(File.Exists(file))
            {
                string text = File.ReadAllText(file); //Put all text in one string
                separated = text.Split(","); //Names are separated by commas
            }
            return separated;      
        }

        ///<param name="vector"> Array that contains the names in the file </param>
        ///<param name="first"> Position where quicksort begins </param>
        ///<param name="last"> Position where quicksort ends </param>

        public void quicksort(string[] vector, int first, int last)
        {
            int i, j, central;
            string pivote;
            central = (first + last) / 2;
            pivote = vector[central];
            i = first;
            j = last;
            do
            {
                while(String.Compare(vector[i], pivote) < 0)
                {
                    i++;
                }
                while(String.Compare(vector[j], pivote) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    string temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (first < j)
            {
                quicksort(vector, first, j);
            }
            if (i < last)
            {
                quicksort(vector, i, last);
            }
        }

        ///<param name="name"> The name from which we will get the "value" </param>
        ///<returns> Returns the value of a name </returns>

        public int getValue(string name)
        {
            int sumName = 0;
            for(int i=1; i < name.Length-1; i++)
            {
                sumName += (name[i] - '0') - 16;
            }
            return sumName;
        }

        ///<param name="separated"> Array that contains all the names in the file </param>
        ///<returns> Returns the total sum of all the scores of the names </returns>
        
        public int getSum(string[] separated)
        {
            int totalSum = 0;
            int valueName;
            for(int i=0; i < separated.Length; i++)
            {
                valueName = getValue(separated[i]);
                totalSum += valueName * (i+1);
            }
            return totalSum;
        }

        public void print()
        {
            string[] vector;
            int res;
            vector = readTxt();
            quicksort(vector, 0, vector.Length - 1);
            res = getSum(vector);
            Console.WriteLine("The total of all the name scores in the file is {0}", res);
        }
    }
}