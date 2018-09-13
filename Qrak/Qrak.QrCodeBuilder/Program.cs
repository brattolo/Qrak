using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Qrak.QrCodeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = Directory.CreateDirectory("output");
            using (Image<Rgba32> image = new Image<Rgba32>(100, 100))
            {
                image.Save("output/qrCode.png");
            }
        }
    }
}
