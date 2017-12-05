using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day5
    {
        public Day5()
        {

        }

        public void Run()
        {
            //PuzzelOne();
            PuzzelTwo();
        }

        private void PuzzelOne()
        {
            string[] input = File.ReadAllLines(@"C:\VS\5.txt");
            List<int> list = new List<int>();
            bool done = false;
            int index = 0;
            int prevIndex = 0;
            int steps = 0;

            foreach (var line in input.ToList())
            {
                if (line.Contains("-"))
                {
                    list.Add(-Int32.Parse(line.Replace("-", "")));
                }
                else
                {
                    list.Add(Int32.Parse(line));
                }
            }

            do
            {
                if (index >= 1074)
                {
                    done = true;
                }
                else
                {
                    if (list[index] == 0)
                    {
                        list[index]++;
                        steps++;
                        continue;
                    }
                    if (list[index] > 0)
                    {
                        prevIndex = index;
                        index += list[index];
                        list[prevIndex]++;
                        steps++;
                        continue;
                    }
                    if (list[index] < 0)
                    {
                        prevIndex = index;
                        index += list[index];
                        list[prevIndex]++;
                        steps++;
                        continue;
                    }
                }
                
            } while (!done);

            string stop = null;
        }

        private void PuzzelTwo()
        {
            string[] input = File.ReadAllLines(@"C:\VS\5.txt");
            List<int> list = new List<int>();
            bool done = false;
            int index = 0;
            int prevIndex = 0;
            int steps = 0;

            foreach (var line in input.ToList())
            {
                if (line.Contains("-"))
                {
                    list.Add(-Int32.Parse(line.Replace("-", "")));
                }
                else
                {
                    list.Add(Int32.Parse(line));
                }
            }

            do
            {
                if (index >= 1074)
                {
                    done = true;
                }
                else
                {
                    if (list[index] == 0)
                    {
                        list[index]++;
                        steps++;
                        continue;
                    }
                    if (list[index] > 0)
                    {
                        prevIndex = index;
                        index += list[index];

                        if (list[prevIndex] >= 3)
                        {
                            list[prevIndex]--;
                        }
                        else
                        {
                            list[prevIndex]++;
                        }
                        steps++;
                        continue;
                    }
                    if (list[index] < 0)
                    {
                        prevIndex = index;
                        index += list[index];

                        if (list[prevIndex] >= 3)
                        {
                            list[prevIndex]--;
                        }
                        else
                        {
                            list[prevIndex]++;
                        }
                        steps++;
                        continue;
                    }
                }

            } while (!done);

            string stop = null;
        }
    }
}
