using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace SecretGarden
{
    class ImageHelper
    {

        public static void Brightness(string srcFileName, string destFileName, float grain)
        {

            var bitPic = new Bitmap(srcFileName);

            if (!(bitPic.RawFormat.Equals(ImageFormat.Bmp) ||

                bitPic.RawFormat.Equals(ImageFormat.Jpeg) ||

                bitPic.RawFormat.Equals(ImageFormat.Png)))
            {


                return;

            }


            Color c;

            Func<int, int> notOver255 = (x) => { return x > 255 ? 255 : x; };

            for (int y = 0; y < bitPic.Height; y++)
            {

                for (int x = 0; x < bitPic.Width; x++)
                {

                    c = bitPic.GetPixel(x, y);

                    Color brightColor = Color.FromArgb(

                        notOver255((int)(c.R * grain)),

                        notOver255((int)(c.G * grain)),

                        notOver255((int)(c.B * grain)));

                    bitPic.SetPixel(x, y, brightColor);

                }

            }

            bitPic.Save(destFileName);

        }
    }
}
