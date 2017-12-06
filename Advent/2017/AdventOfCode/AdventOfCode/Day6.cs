using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day6
    {
        public Day6()
        {

        }

        public void Run()
        {
            //PuzzelOne();
            PuzzelTwo();
        }

        private void PuzzelOne()
        {
            string input = File.ReadAllText(@"C:\VS\6.txt");

            List<int> inputList = new List<int>();
            List<string> configList = new List<string>();

            foreach (var item in input.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList())
            {
                inputList.Add(Int32.Parse(item));
            }

            bool duplicateBank = false;

            do
            {
                if (configList.Count != configList.Distinct().Count())
                {
                    duplicateBank = true;
                }
                else
                {
                    int bank = inputList.Max();
                    int index = inputList.FindIndex(x => x.Equals(bank));
                    int bankIndex = index;
                    inputList[index] = 0;

                    while (bank > 0)
                    {
                        index++;

                        if (index >= inputList.Count)
                        {
                            index = 0;
                        }
                        if ((index == bankIndex) && bank > 1)
                        {
                            index++;
                        }

                        bank--;
                        inputList[index]++;                       
                    }

                    string config = null;
                    foreach (int item in inputList)
                    {
                        config += item.ToString() + "-";
                    }

                    configList.Add(config.Remove(config.Length - 1));
                }
            } while (!duplicateBank);

            int result = configList.Count;
        }

        private void PuzzelTwo()
        {
            string input = File.ReadAllText(@"C:\VS\6.txt");

            List<int> inputList = new List<int>();
            List<string> configList = new List<string>();

            foreach (var item in input.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList())
            {
                inputList.Add(Int32.Parse(item));
            }

            bool duplicateBank = false;
            int result = 0;

            do
            {
                if (configList.Count != configList.Distinct().Count())
                {
                    string toFind = configList.Last();

                    int last = configList.Count - 1;
                    int first = configList.FindIndex(x => x.Equals(toFind));

                    result = last - first;

                    duplicateBank = true;
                }
                else
                {
                    int bank = inputList.Max();
                    int index = inputList.FindIndex(x => x.Equals(bank));
                    int bankIndex = index;
                    inputList[index] = 0;

                    while (bank > 0)
                    {
                        index++;

                        if (index >= inputList.Count)
                        {
                            index = 0;
                        }
                        if ((index == bankIndex) && bank > 1)
                        {
                            index++;
                        }

                        bank--;
                        inputList[index]++;
                    }

                    string config = null;
                    foreach (int item in inputList)
                    {
                        config += item.ToString() + "-";
                    }

                    configList.Add(config.Remove(config.Length - 1));
                }
            } while (!duplicateBank);
        }
    }
}
