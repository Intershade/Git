using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016Day12_1
{
    public class Day24cs
    {
        public Day24cs()
        {

        }

        char[,] matrix;
        List<string> input = File.ReadAllLines(@"C:\VS\2016\24.txt").ToList();

        public void Run()
        {
            int numberOfRows = input.Count();
            int numberOfColumns = input[0].Count();

            string[,] test = new string[numberOfRows, numberOfColumns];
            matrix = new char[numberOfRows, numberOfColumns];
            //char position = matrix[];

            int i = 0;
            int j = 0;
            foreach (string line in input)
            {
                j = 0;
                foreach (char column in line.ToCharArray())
                {
                    test[i, j] = column.ToString();
                    matrix[i, j] = column;
                    j++;
                }
                i++;
            }
            KeyValuePair<int, int> pair = GetMatrixPosition('0');
            int row = pair.Key;
            int col = pair.Value;
            char position = matrix[row, col];




        }

        private List<char> GetSurronding()
        {

        }

        private KeyValuePair<int, int> GetMatrixPosition(char item)
        {
            int row = 0;
            int col = 0;
            if (item == '0')
            {
                foreach (var line in input)
                {
                    col = 0;
                    foreach (char c in line.ToCharArray())
                    {
                        if (c == item)
                        {
                            return new KeyValuePair<int, int>(row, col);
                        }
                        col++;
                    }

                    row++;
                }

                return new KeyValuePair<int, int>(row, col);
            }

            return new KeyValuePair<int, int>(row, col);
        }
    }
}
