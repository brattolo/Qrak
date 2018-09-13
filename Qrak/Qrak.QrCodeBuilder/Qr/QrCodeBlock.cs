using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qrak.QrCodeBuilder.Qr
{
    public class QrCodeBlock
    {
        public QrCodeBlock(int x, int y)
        {
            this.Position = new QrCodeBlockPosition(x, y);
            this.Color = new QrCodeBlockColor();
        }

        public QrCodeBlockPosition Position { get; private set; }
        public QrCodeBlockColor Color { get; private set; }
    }
}
