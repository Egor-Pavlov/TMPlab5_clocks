using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPlab5_clocks
{
    class DigitTime
    {
        public ushort Hour   { get; protected set; }
        public ushort Minute { get; protected set; }
        public ushort Second { get; protected set; }

        public DigitTime(ushort Hour, ushort Minute, ushort Second)
        {
            this.Hour = Hour;
            this.Minute = Minute;
            this.Second = Second;
        }
    }
}
