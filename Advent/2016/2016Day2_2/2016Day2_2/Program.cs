using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016Day2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"C:\VS\2.txt");

            // Start at "5"
            char position = '5';

            string up = "U";
            string down = "D";
            string left = "L";
            string right = "R";

            // 1-2-3
            // 4-5-6
            // 7-8-9

            //List<List<int>> matrix = new List<List<int>>();
            //int[,] matrix = new int[,]
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            char[,] matrix = new char[,]
            {
                { '0', '0', '1', '0', '0' },
                { '0', '2', '3', '4', '0' },
                { '5', '6', '7', '8', '9' },
                { '0', 'A', 'B', 'C', '0' },
                { '0', '0', 'D', '0', '0' }
            };

            List<char> UAddBtn = new List<char>() { '1', '2', '5', '4', '9' };
            List<char> DAddBtn = new List<char>() { 'D', 'A', '5', 'C', '9' };
            List<char> LAddBtn = new List<char>() { '1', '2', '5', 'A', 'D' };
            List<char> RAddBtn = new List<char>() { '1', '4', '9', 'C', 'D' };

            string code = null;
            int ud = 2;
            int lr = 0;
            position = matrix[ud, lr];

            foreach (string line in input)
            {
                foreach (char item in line.ToCharArray())
                {
                    if (item == 'U')
                    {
                        if (UAddBtn.Contains(position))
                        {
                            continue;
                        }
                        else
                        {
                            // else move to next button
                            ud--;
                            position = matrix[ud, lr];
                            continue;
                        }

                    }
                    if (item == 'D')
                    {
                        if (DAddBtn.Contains(position))
                        {
                            continue;
                        }
                        else
                        {
                            ud++;
                            position = matrix[ud, lr];
                            continue;
                        }
                    }
                    if (item == 'L')
                    {
                        if (LAddBtn.Contains(position))
                        {
                            continue;
                        }
                        else
                        {
                            lr--;
                            position = matrix[ud, lr];
                            continue;
                        }
                    }
                    if (item == 'R')
                    {
                        if (RAddBtn.Contains(position))
                        {
                            continue;
                        }
                        else
                        {
                            lr++;
                            position = matrix[ud, lr];
                            continue;
                        }
                    }
                }

                code += position.ToString();

            }

            string stop = null;
        }
    }
}
