using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qrak.QrCodeBuilder.Qr
{
    public class QrCodeBlockColorGrey : QrCodeBlockBaseColor
    {
        public QrCodeBlockColorGrey() : base(255 /2, 255 / 2, 255 / 2)
        {
        }
    }
}
