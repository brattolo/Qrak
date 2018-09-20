using System;
using System.IO;
using Qrak.QrCodeBuilder.Qr;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.Primitives;
using SixLabors.Shapes;
using CoreRectangle = SixLabors.Primitives.Rectangle;

namespace Qrak.QrCodeBuilder
{
    class Program
    {
        public static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = Directory.CreateDirectory("output");
            QrCode qrCode = new QrCode();
            using (Image<Rgba32> image = new Image<Rgba32>(qrCode.WidthInPixels, qrCode.HeightInPixels))
            {
                QrCodeBlock[,] qrCodeBlocks = qrCode.Create();

                for (int x = 0; x < qrCode.xMaxBlocks; x++)
                {
                    for (int y = 0; y < qrCode.yMaxBlocks; y++)
                    {
                        QrCodeBlock qrCodeBlock = qrCodeBlocks[x, y];
                        Draw(image, qrCodeBlock);
                    }
                }

                image.Save("output/qrCode.jpg");
            }
        }

        private static void Draw(Image<Rgba32> image, QrCodeBlock qrCodeBlock)
        {
            CoreRectangle rectangle = new CoreRectangle(
                                        qrCodeBlock.Position.X1,
                                        qrCodeBlock.Position.Y1,
                                        qrCodeBlock.Position.Width,
                                        qrCodeBlock.Position.Height
                                    );

            Rgba32 color = new Rgba32(qrCodeBlock.Color.Red, qrCodeBlock.Color.Green, qrCodeBlock.Color.Blue);
            image.Mutate(ctx => ctx.Fill(color, rectangle));
        }
    }
}
