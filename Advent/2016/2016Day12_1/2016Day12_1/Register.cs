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
        private List<string> _log;
        private int _pos;
        private bool _end;

        /// <summary>
        /// Input list of program instructions
        /// </summary>
        /// <param name="program"></param>
        public Register(List<string> program)
        {
            _log = new List<string>();
            this._program = program;
            this._pos = 0;
            this._end = false;
            this.c = 0;
        }

        /// <summary>
        /// copies x (either an integer or the value of a register) into register y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void cpy(string val, string reg)
        {
            if (int.TryParse(val, out var value))
            {
                cpyValue(reg, value);
            }
            else if (!int.TryParse(val, out var v))
            {
                cpyRegister(reg, val);
            }
        }

        private void cpyValue(string reg, int value)
        {
            if (reg.ToLower().Equals("a"))
            {
                this.a = value;
            }
            if (reg.ToLower().Equals("b"))
            {
                this.b = value;
            }
            if (reg.ToLower().Equals("c"))
            {
                this.c = value;
            }
            if (reg.ToLower().Equals("d"))
            {
                this.d = value;
            }
        }

        private void cpyRegister(string reg, string value)
        {
            int val = -999;

            if (value.ToLower().Equals("a"))
            {
                val = this.a;
            }
            if (value.ToLower().Equals("b"))
            {
                val = this.b;
            }
            if (value.ToLower().Equals("c"))
            {
                val = this.c;
            }
            if (value.ToLower().Equals("d"))
            {
                val = this.d;
            }

            if (reg.ToLower().Equals("a"))
            {
                this.a = val;
            }
            if (reg.ToLower().Equals("b"))
            {
                this.b = val;
            }
            if (reg.ToLower().Equals("c"))
            {
                this.c = val;
            }
            if (reg.ToLower().Equals("d"))
            {
                this.d = val;
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
            if (int.TryParse(x, out var value))
            {
                if (value != 0)
                {

                }
            }

            if (x.ToLower().Equals("a"))
            {
                if (a == 0)
                {
                    nxt();
                    return;
                }
            }
            if (x.ToLower().Equals("b"))
            {
                if (b == 0)
                {
                    nxt();
                    return;
                }
            }
            if (x.ToLower().Equals("c"))
            {
                if (c == 0)
                {
                    nxt();
                    return;
                }
            }
            if (x.ToLower().Equals("d"))
            {
                if (d == 0)
                {
                    nxt();
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
            if (_pos >= 23)
            {
                string stop = null;
            }
            _log.Add(_program[_pos]);
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

        public int ProgramCount()
        {
            return _program.Count;
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
