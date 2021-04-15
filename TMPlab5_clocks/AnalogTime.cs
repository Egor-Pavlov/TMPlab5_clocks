using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPlab5_clocks
{
    class AnalogTime
    {
        public ushort Hour   { get; set; }
        public ushort Minute { get; set; }
        public ushort Second { get; set; }

        public AnalogTime(ushort HourA, ushort MinuteA, ushort SecondA)
        {
            this.Hour = HourA;
            this.Minute = MinuteA;
            this.Second = SecondA;
        }
    }
}
