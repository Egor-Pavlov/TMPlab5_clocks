using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPlab5_clocks
{
    class DigitAdapter:DigitTime
    {
        public DigitAdapter(AnalogTime Time) :
            base((ushort)(Time.Hour / 30), (ushort)(Time.Minute / 6), (ushort)(Time.Second / 6))
        { }
    }
}

