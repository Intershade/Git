using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day1
    {
        public Day1()
        {

        }

        public void Run()
        {
            //PuzzelOne();
            PuzzelTwo();
        }

        private void PuzzelOne()
        {
            string input = File.ReadAllText(@"C:\VS\1.txt");
            int sum = 0;
            int nextNumber = 0;
            int number = 0;
            int position = 0;

            foreach (char c in input.ToCharArray())
            {
                position++;
                number = (int)Char.GetNumericValue(c);

                if (input.Length != position)
                {
                    nextNumber = (int)Char.GetNumericValue(input.ToCharArray()[position]);
                }
                else
                {
                    nextNumber = (int)Char.GetNumericValue(input.ToCharArray()[0]);
                }

                if (number == nextNumber)
                {
                    sum += number;
                }
            }

            string stop = null;
        }

        private void PuzzelTwo()
        {
            string input = File.ReadAllText(@"C:\VS\1_2.txt");
            int sum = 0;
            int nextNumber = 0;
            int number = 0;
            int position = (input.Length) / 2;

            foreach (char c in input.ToCharArray())
            {
                number = (int)Char.GetNumericValue(c);

                if (position == input.Length)
                {
                    position = 0;
                }

                nextNumber = (int)Char.GetNumericValue(input.ToCharArray()[position]);

                if (number == nextNumber)
                {
                    sum += number;
                }

                position++;
            }

            string stop = null;
        }     
    }
}
