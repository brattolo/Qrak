using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qrak.QrCodeBuilder.Qr
{
    public class QrCodeVersion
    {
        private const int baseSize = 17;
        private const int blocksAddedPerVersion = 4;

        public QrCodeVersion(int version)
        {
            if (version < 1 || version > 40)
            {
                throw new InvalidOperationException($"The value '{version}' is not valid, this has to be between 1 and 40.");
            }

            int size = baseSize + blocksAddedPerVersion * version;

            this.AmountOfColumnsAsIndex = size - 1;
            this.AmountOfRowsAsIndex = size - 1;

        }

        public int AmountOfColumnsAsIndex { get; private set; }
        public int AmountOfRowsAsIndex { get; private set; }
    }
}
