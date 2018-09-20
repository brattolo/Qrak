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
            this.Color = new QrCodeBlockColorGrey();
        }

        public QrCodeBlockPosition Position { get; }
        public QrCodeBlockBaseColor Color { get; private set; } = new QrCodeBlockColorGrey();

        public void Black()
        {
            this.Color = new QrCodeBlockColorBlack();
        }

        public void White()
        {
            this.Color = new QrCodeBlockColorWhite();
        }
    }
}
