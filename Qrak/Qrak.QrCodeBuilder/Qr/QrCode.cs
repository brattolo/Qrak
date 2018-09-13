using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qrak.QrCodeBuilder.Qr
{
    public class QrCode
    {
        public QrCode()
        {
            this.Version = new QrCodeVersion(version: 1);

            this.WidthInPixels = this.Version.AmountOfColumns * QrCodeConstants.BaseSizeInPixels;
            this.HeightInPixels = this.Version.AmountOfRows * QrCodeConstants.BaseSizeInPixels;

            this.Blocks = new QrCodeBlock[this.Version.AmountOfRows, this.Version.AmountOfColumns];
        }

        public int WidthInPixels { get; private set; }
        public int HeightInPixels { get; private set; }

        public QrCodeVersion Version { get; private set; }

        public QrCodeBlock[,] Blocks { get; private set; }

        public QrCodeBlock[,] Create()
        {
            for (int x = 0; x < this.Version.AmountOfRowsAsIndex; x++)
            {
                for (int y = 0; y < this.Version.AmountOfColumnsAsIndex; y++)
                {
                    this.Blocks[x, y] = new QrCodeBlock(x, y);
                }
            }

            return this.Blocks;
        }
    }
}
