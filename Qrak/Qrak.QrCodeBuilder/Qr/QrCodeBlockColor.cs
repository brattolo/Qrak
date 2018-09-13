using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qrak.QrCodeBuilder.Qr
{
    public class QrCodeBlockColor
    {
        public byte Red { get; private set; } = 255 / 2;
        public byte Green { get; private set; } = 158;
        public byte Blue { get; private set; } = 255;
    }
}
