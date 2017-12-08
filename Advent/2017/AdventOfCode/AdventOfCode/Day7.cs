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
            //PuzzelOne();
            PuzzelTwo();
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
            List<string> input = File.ReadAllLines(@"C:\VS\7.txt").ToList();
            //string input = File.ReadAllText(@"C:\VS\7.txt");

            Dictionary<string, int> totalWeight = new Dictionary<string, int>();

            string bottom = input[input.FindIndex(x => x.Contains("ykpsek"))];

            string[] bottomSplit = bottom.Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);

            string values = bottomSplit[1].Replace(" ","");

            foreach (string level1 in values.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                int valueSumLevel1 = Int32.Parse(input[input.FindIndex(x => x.StartsWith(level1))].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                string[] nxtLevel1 = input[input.FindIndex(x => x.StartsWith(level1))].Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);

                int valueSumLevel2 = 0;
                int valueSumLevel3 = 0;
                int valueSumLevel4 = 0;
                int valueSumLevel5 = 0;
                int valueSumLevel6 = 0;
                int valueSumLevel7 = 0;
                int valueSumLevel8 = 0;

                foreach (var level2 in nxtLevel1[1].Replace(" ","").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    valueSumLevel2 = Int32.Parse(input[input.FindIndex(x => x.StartsWith(level2))].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                    string[] nxtLevel2 = input[input.FindIndex(x => x.StartsWith(level2))].Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var level3 in nxtLevel2[1].Replace(" ", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        valueSumLevel3 = Int32.Parse(input[input.FindIndex(x => x.StartsWith(level3))].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                        string[] nxtLevel3 = input[input.FindIndex(x => x.StartsWith(level3))].Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var level4 in nxtLevel3[1].Replace(" ", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                        {
                            valueSumLevel4 = Int32.Parse(input[input.FindIndex(x => x.StartsWith(level4))].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                            string[] nxtLevel4 = input[input.FindIndex(x => x.StartsWith(level4))].Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);

                            foreach (var level5 in nxtLevel4[1].Replace(" ", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                            {
                                valueSumLevel5 = Int32.Parse(input[input.FindIndex(x => x.StartsWith(level5))].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                                string[] nxtLevel5 = input[input.FindIndex(x => x.StartsWith(level5))].Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);

                                foreach (var level6 in nxtLevel5[1].Replace(" ", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                                {
                                    valueSumLevel6 = Int32.Parse(input[input.FindIndex(x => x.StartsWith(level6))].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                                    string[] nxtLevel6 = input[input.FindIndex(x => x.StartsWith(level6))].Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);

                                    foreach (var level7 in nxtLevel6[1].Replace(" ", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                                    {
                                        valueSumLevel7 = Int32.Parse(input[input.FindIndex(x => x.StartsWith(level7))].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                                        string[] nxtLevel7 = input[input.FindIndex(x => x.StartsWith(level7))].Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);

                                        foreach (var level8 in nxtLevel7[1].Replace(" ", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                                        {
                                            valueSumLevel8 = Int32.Parse(input[input.FindIndex(x => x.StartsWith(level8))].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                                            string[] nxtLevel8 = input[input.FindIndex(x => x.StartsWith(level8))].Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                int totalSum = valueSumLevel1 + valueSumLevel2 + valueSumLevel3 + valueSumLevel4 + valueSumLevel5 + valueSumLevel6 + valueSumLevel7 + valueSumLevel8;
                totalWeight.Add(level1, totalSum);
            }
            
        }
    }
}
