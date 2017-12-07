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

        private void PuzzelOne()
        {
            int n = 289326;
            int x = 0;
            int y = 0;
            int w = 1;
            int h = 1;
            int i = 1;

            while (i <= n)
            {
                // Go max right
                if ((i+w) <= n)
                {
                    i += w;
                    x += w;
                    w += 1;
                }
                else
                {
                    x += n - i;
                    break;
                }

                // Go max up
                if ((i + h) <= n)
                {
                    i += h;
                    y -= h;
                    h += 1;
                }
                else
                {
                    y -= n - i;
                    break;
                }

                // Go max left
                if ((i + w) <= n)
                {
                    i += w;
                    x -= w;
                    w += 1;
                }
                else
                {
                    x -= n - i;
                    break;
                }

                // Go max down
                if ((i + h) <= n)
                {
                    i += h;
                    y += h;
                    h += 1;
                }
                else
                {
                    y += n - i;
                    break;
                }
            }

            var result = Math.Abs(x) + Math.Abs(y);
        }


        private void PuzzelTwo()
        {
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
    }
}
