using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day7
    {
        public Day7()
        {

        }

        public void Run()
        {
            PuzzelOne();
            //PuzzelTwo();
        }

        private void PuzzelOne()
        {
            List<string> input = File.ReadAllLines(@"C:\VS\5.txt").ToList();
            //string input = File.ReadAllText(@"C:\VS\7.txt");

            //List<string> topPrg = new List<string>();
            string topPrg = null;

            string xgudb = input.Find(x => x.Contains("xgudb ("));
            string fucsb = input.Find(x => x.Contains("fucsb ("));
            string rsalq = input.Find(x => x.Contains("rsalq ("));
            string xjllex = input.Find(x => x.Contains("xjllex ("));
            string splbrdu = input.Find(x => x.Contains("splbrdu ("));
        }

        private void PuzzelTwo()
        {
            //string[] input = File.ReadAllLines(@"C:\VS\5.txt");
            string input = File.ReadAllText(@"C:\VS\7.txt");
        }
    }
}
