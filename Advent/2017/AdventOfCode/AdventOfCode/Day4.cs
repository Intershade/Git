using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day4
    {
        public Day4()
        {

        }

        public void Run()
        {
            PuzzelOne();
            PuzzelTwo();
        }

        private void PuzzelOne()
        {
            string[] input = File.ReadAllLines(@"C:\VS\4.txt");
            List<string> pass = new List<string>();

            foreach (var item in input)
            {
                List<string> splitStr = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                splitStr.Sort();

                if (splitStr.GroupBy(n => n).Any(c => c.Count() > 1))
                {
                    continue;
                }

                pass.Add(item);
            }

            string s = null;
        }

        private void PuzzelTwo()
        {
            string[] input = File.ReadAllLines(@"C:\VS\4_2.txt");
            List<string> pass = new List<string>();

            foreach (var item in input)
            {
                string rcon = null;
                foreach (var c in item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList())
                {
                    char[] a = c.ToCharArray();
                    Array.Sort(a);
                    rcon += new string(a) + " ";

                }
                List<string> splitStr = rcon.Remove(rcon.Length - 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                splitStr.Sort();

                if (splitStr.GroupBy(n => n).Any(c => c.Count() > 1))
                {
                    continue;
                }

                pass.Add(item);
            }

            string s = null;
        }
    }
}
