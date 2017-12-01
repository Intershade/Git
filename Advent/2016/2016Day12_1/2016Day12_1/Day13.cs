using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016Day12_1
{
    public class Day13
    {
        private int _x;
        private int _y;
        private readonly string path = @"C:\VS\output13.txt";

        public Day13()
        {
            _x = 1;
            _y = 1;
        }

        public int x
        {
            get { return _x; }
            set { _x = value;  }
        }

        public int y
        {
            get { return _y; }
            set { _y = value; }
        }

        public void Run()
        {
            DrawMap();
        }
        private int FindN(int x, int y)
        {
            int N = ((x*x)+(3*x)+(2*x*y)+y+(y*y));
            return N + 10;
        }
        private bool IsEven(int n)
        {
            var binary = Convert.ToString(n, 2);

            string test = binary.Replace("0","");
            int binaryCount = test.Count();

            if ((binaryCount % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DrawMap()
        {
            char[,] matrix = new char[34,43];
            List<string> matr = new List<string>();
            string row = null;

            for (int y = 0; y <= 42; y++)
            {
                row = null;
                for (int x = 0; x <= 33; x++)
                {
                    int n = FindN(x, y);
                    bool even = IsEven(n);

                    if (x == 7 && y == 4)
                    {
                        matrix[x, y] = 'X';
                        row += matrix[x, y].ToString();
                        continue;
                    }

                    if (even)
                    {
                        matrix[x, y] = '.';
                    }
                    else
                    {
                        matrix[x, y] = '#';
                    }

                    row += matrix[x, y].ToString();
                }

                matr.Add(row);
            }

            TextWriter tw = new StreamWriter(path);

            foreach (var item in matr)
            {
                tw.WriteLine(item);
            }

            tw.Close();
            string stop = null;
        }
    }
}
