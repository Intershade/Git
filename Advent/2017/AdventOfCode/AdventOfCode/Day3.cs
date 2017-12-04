using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day3
    {
        public Day3()
        {

        }

        public void Run()
        {
            PuzzelOne();
            PuzzelTwo();
        }

        private void PuzzelTwo()
        {
            //int n = 289326;
            //int[,] matrix = new int[540,540];

            //int x = 269;
            //int y = 269;
            //matrix[x, y] = 1;
            int n = 289326;

            var x = 0;
            var y = 0;

            var stepCount = 1; // Initial step amount.
            var stepCountChange = true; // Change when true.
            var direction = 0;
            var values = new Dictionary<string, int>();

            values["0,0"] = 1;

            for (; ; )
            {
                for (var j = 0; j < stepCount; j += 1)
                {
                    // Take a step
                    switch (direction)
                    {
                        case 0:
                            // right
                            x += 1;
                            break;
                        case 1:
                            // up
                            y += 1;
                            break;

                        case 2:
                            // left
                            x -= 1;
                            break;

                        case 3:
                            // down
                            y -= 1;
                            break;
                        default:
                            break;
                    }

                    // Determine sum of neighbours for value of current location.
                    var sum = 0;
                    var val = 0;

                    if (values.TryGetValue(string.Format("{0},{1}", x + 1, y), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x + 1, y + 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x, y + 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x - 1, y + 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x - 1, y), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x - 1, y - 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x, y - 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x + 1, y - 1), out val)) sum += val;

                    // Check here to see if the sum exceeds our input. Otherwise, store the sum computed and continue.
                    if (sum > n)
                    {
                        string sto = null;
                    }
                    values[string.Format("{0},{1}", x, y)] = sum;
                }

                direction = (direction + 1) % 4;
                stepCountChange = !stepCountChange;
                if (stepCountChange) stepCount += 1;
            }

        }

        private void PuzzelOne()
        {
            int n = 289326;

            var x = 0;
            var y = 0;

            var stepCount = 1; // Initial step amount.
            var stepCountChange = true; // Change when true.
            var direction = 0; // right, up, left, down

            // Get the x,y coordinate for each step of i. 
            for (var i = 1; ;)
            {
                for (var j = 0; j < stepCount; j += 1)
                {
                    // Take a step
                    switch (direction)
                    {
                        case 0:
                            // right
                            x += 1;
                            break;
                        case 1:
                            // up
                            y += 1;
                            break;

                        case 2:
                            // left
                            x -= 1;
                            break;

                        case 3:
                            // down
                            y -= 1;
                            break;
                        default:
                            break;
                    }

                    // Needs to be incremented here after we take a step.
                    // Then we check the outer loop condition here, and so then jump out if needed.
                    // The ghost of Djikstra will probably haunt me for a bit now...~
                    i += 1;

                    if (i == n) goto EndOfLoop;
                }

                direction = (direction + 1) % 4;
                stepCountChange = !stepCountChange;
                if (stepCountChange) stepCount += 1;
            }
            EndOfLoop:
            var l1distance = Math.Abs(x) + Math.Abs(y);

            System.Diagnostics.Debug.WriteLine("f({0}) = ({1},{2}), |f({0})| = {3}", n, x, y, l1distance);

            string stop = null;
        }
    }
}
