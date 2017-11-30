using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2016Day12_1
{
    public class Register
    {
        private int a;
        private int b;
        private int c;
        private int d;
        private List<string> _program;
        private int _pos;
        private bool _end;

        /// <summary>
        /// Input list of program instructions
        /// </summary>
        /// <param name="program"></param>
        public Register(List<string> program)
        {
            this._program = program;
            this._pos = 0;
            this._end = false;
        }

        /// <summary>
        /// copies x (either an integer or the value of a register) into register y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void cpy(string x, string y)
        {
            if (y.ToLower().Equals("a") && int.TryParse(x, out var a))
            {
                this.a = a;
            }
            else if(y.ToLower().Equals("a") && !int.TryParse(x, out var a1))
            {
                var value = this.GetType().GetField(x, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this);
                this.a = int.Parse(value.ToString());
            }

            if (y.ToLower().Equals("b") && int.TryParse(x, out var b))
            {
                this.b = b;
            }
            else if (y.ToLower().Equals("b") && !int.TryParse(x, out var b1))
            {
                var value = this.GetType().GetField(x, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this);
                this.b = int.Parse(value.ToString());
            }
            if (y.ToLower().Equals("c") && int.TryParse(x, out var c))
            {
                this.c = c;
            }
            else if (y.ToLower().Equals("c") && !int.TryParse(x, out var c1))
            {
                var value = this.GetType().GetField(x, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this);
                this.c = int.Parse(value.ToString());
            }
            if (y.ToLower().Equals("d") && int.TryParse(x, out var d))
            {
                this.d = d;
            }
            else if (y.ToLower().Equals("d") && !int.TryParse(x, out var d1))
            {
                var value = this.GetType().GetField(x, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this);
                this.d = int.Parse(value.ToString());
            }
        }

        /// <summary>
        /// increases the value of register x by one.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void inc(string x)
        {
            if (x.ToLower().Equals("a"))
            {
                a++;
            }
            if (x.ToLower().Equals("b"))
            {
                b++;
            }
            if (x.ToLower().Equals("c"))
            {
                c++;
            }
            if (x.ToLower().Equals("d"))
            {
                d++;
            }
        }

        /// <summary>
        /// decreases the value of register x by one.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void dec(string x)
        {
            if (x.ToLower().Equals("a"))
            {
                a--;
            }
            if (x.ToLower().Equals("b"))
            {
                b--;
            }
            if (x.ToLower().Equals("c"))
            {
                c--;
            }
            if (x.ToLower().Equals("d"))
            {
                d--;
            }
        }

        /// <summary>
        /// jumps to an instruction y away (positive means forward; negative means backward), but only if x is not zero.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void jnz(string x, int y)
        {
            if (x.ToLower().Equals("a"))
            {
                if (a == 0)
                {
                    return;
                }
            }
            if (x.ToLower().Equals("b"))
            {
                if (b == 0)
                {
                    return;
                }
            }
            if (x.ToLower().Equals("c"))
            {
                if (c == 0)
                {
                    return;
                }
            }
            if (x.ToLower().Equals("d"))
            {
                if (d == 0)
                {
                    return;
                }
            }

            _pos += y;
        }

        public bool end()
        {
            return _end;
        }

        public string inst()
        {
            return _program[_pos];
        }

        public void nxt()
        {
            if (_pos == _program.Count)
            {
                _end = true;
            }

            _pos++;
        }

        public int position()
        {
            return _pos;
        }

        public int GetValueFromRegister(string register)
        {
            if (register.ToLower().Equals("a"))
            {
                return a;
            }
            if (register.ToLower().Equals("b"))
            {
                return b;
            }
            if (register.ToLower().Equals("c"))
            {
                return c;
            }
            if (register.ToLower().Equals("d"))
            {
                return d;
            }

            return -999;
        }

    }
}
