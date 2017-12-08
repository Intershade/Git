using AdventOfCode.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day8
    {
        public Day8()
        {

        }

        public void Run()
        {
            PuzzelOne();
            //PuzzelTwo();
        }

        private void PuzzelOne()
        {
            List<string> input = File.ReadAllLines(@"C:\VS\8.txt").ToList();
            Dictionary<string, int> register = new Dictionary<string, int>();
            List<int> highestValue = new List<int>();
            highestValue.Add(0);

            foreach (string item in input)
            {
                string[] lineSplit = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (!register.ContainsKey(lineSplit[0]))
                {
                    register.Add(lineSplit[0], 0);
                }

                if (!register.ContainsKey(lineSplit[4]))
                {
                    register.Add(lineSplit[4], 0);
                }
            }

            foreach (string line in input)
            {
                string[] lineSplit = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int minusTest = Int32.Parse(lineSplit[6]);

                if (lineSplit[1] == "inc")
                {
                    int increasValue = Int32.Parse(lineSplit[2]);
                    if (GetModifier.State(register[lineSplit[4]], lineSplit[5], Int32.Parse(lineSplit[6])))
                    {
                        register[lineSplit[0]] += increasValue;
                    }
                }

                if (lineSplit[1] == "dec")
                {
                    int decresevalue = Int32.Parse(lineSplit[2]);
                    if (GetModifier.State(register[lineSplit[4]], lineSplit[5], Int32.Parse(lineSplit[6])))
                    {
                        register[lineSplit[0]] -= decresevalue;
                    }
                }

                var item = register.OrderByDescending(pair => pair.Value)
               .ToDictionary(pair => pair.Key, pair => pair.Value);

                highestValue.Sort();

                if (register[lineSplit[0]] > highestValue[0])
                {
                    highestValue.Add(register[lineSplit[0]]);
                }
            }

            highestValue.Sort();
        }

        private int GetInt(string str)
        {
            return Int32.Parse(str);
        }

        private void PuzzelTwo()
        {
            throw new NotImplementedException();
        }
    }
}
