using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qrak.QrCodeBuilder.Qr
{
    public abstract class QrCodeBlockBaseColor
    {
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }

        protected QrCodeBlockBaseColor(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }
    }
}
