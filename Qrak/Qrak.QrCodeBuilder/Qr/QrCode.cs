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

            this.xMaxBlocks = this.Version.AmountOfRowsAsIndex + QrCodeConstants.AmountOfPaddingBlocks;
            this.yMaxBlocks = this.Version.AmountOfColumnsAsIndex + QrCodeConstants.AmountOfPaddingBlocks;

            this.WidthInPixels = this.xMaxBlocks * QrCodeConstants.BaseSizeInPixels;
            this.HeightInPixels = this.yMaxBlocks * QrCodeConstants.BaseSizeInPixels;
        }

        public int WidthInPixels { get; private set; }
        public int HeightInPixels { get; private set; }

        public int xMaxBlocks { get; private set; }
        public int yMaxBlocks { get; private set; }

        public QrCodeVersion Version { get; private set; }

        public QrCodeBlock[,] Create()
        {
            QrCodeBlock[,] blocks = GetBlocks();

            var creator = new QrCodeCreator();
            creator.Build(ref blocks);

            return blocks;
        }

        private QrCodeBlock[,] GetBlocks()
        {
         

            QrCodeBlock[,] blocks = new QrCodeBlock[this.xMaxBlocks, this.yMaxBlocks];

            for (int x = 0; x < this.xMaxBlocks; x++)
            {
                for (int y = 0; y < this.yMaxBlocks; y++)
                {
                    blocks[x, y] = new QrCodeBlock(x, y);
                }
            }

            return blocks;
        }
    }
}
