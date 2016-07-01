using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace SecretGarden
{
    class Pic
    {

        public string PicUrl { get; set; }
        public string FileName { get; set; }
        public string ThumbsUrl { get; set; }

        public void DownloadPic(string sPath)
        {
            WebClient wc = new WebClient();
            if (!File.Exists(sPath + "\\" + FileName))
            {
                wc.DownloadFile(PicUrl, sPath + "\\" + FileName);
            }

            if (!File.Exists(sPath + "\\thumbs_" + FileName))
            {
                wc.DownloadFile(ThumbsUrl, sPath + "\\thumbs_" + FileName);
            }
        }

    }
}
