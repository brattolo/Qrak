using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qrak.QrCodeBuilder.Qr.QrModule;

namespace Qrak.QrCodeBuilder.Qr
{
    public class QrCodeCreator
    {
        public Module TLModule { get; private set; }
        public Module TRModule { get; private set; }
        public Module BLModule { get; private set; }

        public QrCodeCreator()
        {
        }

        public void Build(ref QrCodeBlock[,] blocks)
        {
            int xMinBegin = QrCodeConstants.AmountOfPaddingBlocks - 1;
            int yMinBegin =  QrCodeConstants.AmountOfPaddingBlocks - 1;
            int xMaxBegin = blocks.GetLength(0) - Module.BaseSize - QrCodeConstants.AmountOfPaddingBlocks - 1;
            int yMaxBegin = blocks.GetLength(1) - Module.BaseSize - QrCodeConstants.AmountOfPaddingBlocks - 1;

            this.TLModule = new Module(ref blocks, startX: xMinBegin, startY: yMinBegin);
            this.TRModule = new Module(ref blocks, startX: xMaxBegin, startY: yMinBegin);
            this.BLModule = new Module(ref blocks, startX: xMinBegin, startY: yMaxBegin);
        }
    }
}
