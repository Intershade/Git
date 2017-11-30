using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2016Day12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> prg = File.ReadAllLines(@"C:\VS\12.txt").ToList();
            Register r = new Register(prg);

            do
            {
                if (r.position() == r.ProgramCount())
                {
                    break;
                }
                string[] str = r.inst().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (str[0].Equals("cpy"))
                {
                    r.cpy(str[1], str[2]);
                    r.nxt();
                }
                if (str[0].Equals("inc"))
                {
                    r.inc(str[1]);
                    r.nxt();
                }
                if (str[0].Equals("dec"))
                {
                    r.dec(str[1]);
                    r.nxt();
                }
                if (str[0].Equals("jnz"))
                {
                    r.jnz(str[1], Int32.Parse(str[2]));
                }

            } while (!r.end());

            int result = r.GetValueFromRegister("a");
        }
    }
}
