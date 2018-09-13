using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qrak.QrCodeBuilder.Qr
{
    public class QrCodeBlockPosition
    {
        public QrCodeBlockPosition(int x, int y)
        {
            this.X1 = x * QrCodeConstants.BaseSizeInPixels;
            this.X2 = x * QrCodeConstants.BaseSizeInPixels + QrCodeConstants.BaseSizeInPixels;

            this.Y1 = y * QrCodeConstants.BaseSizeInPixels;
            this.Y2 = y * QrCodeConstants.BaseSizeInPixels + QrCodeConstants.BaseSizeInPixels;

            this.Width = this.X2 - this.X1;
            this.Height = this.Y2 - this.Y1;
        }

        public int X1 { get; private set; }
        public int X2 { get; private set; }

        public int Y1 { get; private set; }
        public int Y2 { get; private set; }

        public int Width { get; private set; }
        public int Height { get; private set; }
    }
}
