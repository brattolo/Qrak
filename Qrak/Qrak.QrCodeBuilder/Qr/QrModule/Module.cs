using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qrak.QrCodeBuilder.Qr.QrModule
{
    public class Module
    {
        public const int BaseSize = 7;

        private const int margin = 0;
        private const int BaseSizeIndex = BaseSize - 1;
        private const int combinedSize = BaseSize + margin;

        public Module(ref QrCodeBlock[,] blocks, int startX, int startY)
        {
            if (blocks == null)
            {
                throw new ArgumentNullException(nameof(blocks));
            }

            for (int x = 0; x < BaseSize; x++)
            {
                for (int y = 0; y < BaseSize; y++)
                {
                    QrCodeBlock block = blocks[startX + x, startY + y];

                    // --------------
                    // |            |
                    // |            |
                    // |            |
                    // |            |
                    // |            |
                    // --------------
                    bool topSide = x == 0 && y >= 0;
                    bool leftSide = y == 0 && x >= 0;
                    bool bottomSide = x == BaseSizeIndex && y >= 0;
                    bool rightSide = y == BaseSizeIndex && x >= 0;

                    // --------------
                    // |            |
                    // |   ||||||   |
                    // |   ||||||   |
                    // |   ||||||   |
                    // |            |
                    // --------------
                    bool center = x >= 2 && x <= 4 &&
                                  y >= 2 && y <= 4;

                    if (topSide || leftSide || bottomSide || rightSide || center)
                    {
                        block.Black();
                    }
                    else
                    {
                        block.White();
                    }     
                }
            }
        }
    }
}
