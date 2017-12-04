using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day2
    {
        public Day2()
        {

        }

        public void Run()
        {
            //PuzzelOne();
            PuzzelTwo();
        }

        private void PuzzelOne()
        {
            string[] input = File.ReadAllLines(@"C:\VS\2.txt");
            int checkSum = 0;
            List<int> rowCheckSums = new List<int>();

            foreach (var row in input)
            {
                string[] splitStr = row.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int max = 0;
                int low = 3000;

                foreach (var numbr in splitStr)
                {
                    int numbrInt = Int32.Parse(numbr);
                    if (numbrInt > max)
                    {
                        max = numbrInt;
                    }

                    if (numbrInt<low)
                    {
                        low = numbrInt;
                    }
                }

                rowCheckSums.Add(max-low);

            }

            foreach (int rowCheckSum in rowCheckSums)
            {
                checkSum += rowCheckSum;
            }

            string stop = null;
        }

        private void PuzzelTwo()
        {
            string[] input = File.ReadAllLines(@"C:\VS\2.txt");
            int checkSum = 0;
            List<int> rowCheckSums = new List<int>();

            foreach (var row in input)
            {
                string[] splitStr = row.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var numbr in splitStr)
                {
                    int numbrInt = Int32.Parse(numbr);
                    foreach (var nxtNumbr in splitStr)
                    {
                        int nxtNumbrInt = Int32.Parse(nxtNumbr);

                        if (nxtNumbrInt == numbrInt)
                        {
                            continue;
                        }

                        if ((numbrInt % nxtNumbrInt) == 0)
                        {
                            rowCheckSums.Add(numbrInt / nxtNumbrInt);
                            break;
                        }
                    }
                }
            }

            foreach (int rowCheckSum in rowCheckSums)
            {
                checkSum += rowCheckSum;
            }

            string stop = null;
        }
    }
}
