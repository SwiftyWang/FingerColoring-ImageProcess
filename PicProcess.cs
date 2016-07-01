using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
//using System.Drawing.Imaging;

namespace SecretGarden
{
    class PicProcess
    {

        public static List<string> PicFilePath { get; set; }

        public static Bitmap DropNoise(Bitmap srcBitmap)
        {
            Color srcColor;

            int width = srcBitmap.Width;
            int height = srcBitmap.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    srcColor = srcBitmap.GetPixel(x, y);

                    if (srcColor.R < 200 || srcColor.G < 200 || srcColor.B < 200)
                    {
                        srcBitmap.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        srcBitmap.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            return srcBitmap;

        }


        public static List<PicCategory> GetCategory(string sPath, int iMaxCategory)
        {

            List<PicCategory> listCategory = new List<PicCategory>();

            string sUrl = "http://www.coloring-book.info/coloring/coloring_page.php?id=";

            for (int i = 1; i <= iMaxCategory; i++)
            {
                string sRealUrl = sUrl + i.ToString();

                WebClient wc = new WebClient();
                string sHtml = wc.DownloadString(sRealUrl);

                Regex reg = new Regex("<td width=\"95\"><img.*?src=\"(.*?)\".*?></td>.*?<td width=\"468\"><div align=\"center\"><h1 class=\"coloring\">(.*?) coloring pages</h1>", RegexOptions.Singleline);

                Match m = reg.Match(sHtml);

                PicCategory c = new PicCategory();
                c.ID = i;
                c.CategoryPic = @"http://www.coloring-book.info/coloring/" + m.Groups[1].Value;
                c.Name = m.Groups[2].Value.Replace(":", "");
                if (c.Name != "")
                {
                    listCategory.Add(c);
                }

            }

            return listCategory;
        }

        public static void ProcessCategory(string sPath, List<PicCategory> listCategory)
        {
            string sNewPath = sPath + "_processed";
            if (Directory.Exists(sNewPath))
            {
                return;
            }
            Directory.CreateDirectory(sNewPath);

            DirectoryInfo dir = new DirectoryInfo(sPath);
            DirectoryInfo[] dirs = dir.GetDirectories();

            listCategory.Reverse();
            int iCateSort = 0;
            foreach (PicCategory cat in listCategory)
            {
                string s = sNewPath + "\\" + cat.Name + "_" + cat.ID + "_" + iCateSort.ToString();
                if (Directory.Exists(s))
                {
                    return;
                }
                Directory.CreateDirectory(s);

                string[] files = Directory.GetFiles(sPath + "\\" + cat.Name, "*.jpg");

                WebClient wc = new WebClient();
                wc.DownloadFile(cat.CategoryPic, s + "\\category.gif");

                
                int iPicID = 0;
                foreach (string sf in files)
                {
                    if (sf.IndexOf("thumbs_") > 0)
                    {
                        continue;
                    }
                    Bitmap bm = Bitmap.FromFile(sf) as Bitmap;
                    Bitmap outbm = DropNoise(bm);
                    outbm.Save(s + "\\" + "f_" + iPicID.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    string sFile = sf.Substring(sf.LastIndexOf("\\") + 1);
                    string sThumbs = sf.Replace(sFile, "thumbs_" + sFile);
                    File.Copy(sThumbs, s + "\\" + "t_" + iPicID.ToString() + ".jpg");

                    iPicID++;
                    if (iPicID == 10)
                    {
                        //break;
                    }

                }
                iCateSort++;
                cat.MaxPicID = iPicID;
            }

        }

    }
}
