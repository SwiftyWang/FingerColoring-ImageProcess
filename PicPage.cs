using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace SecretGarden
{
    class PicPage
    {

        public string sPageUrl;

        public string sCategory;

        public void DownloadPics(string sPath)
        {
            WebClient wc = new WebClient();
            string sHtml = wc.DownloadString(sPageUrl);

            Regex reg = new Regex("<a href=\"(coloring.php.*?)\".*?<img src=\"(.*?)\"", RegexOptions.Singleline);

            MatchCollection mc = reg.Matches(sHtml);

            List<Pic> listPic = new List<Pic>();

            foreach (Match m in mc)
            {

                string sUrl = "http://www.coloring-book.info/coloring/" + m.Groups[1].Value;
                sHtml = wc.DownloadString(sUrl);

                Match mPic = new Regex("<td style=\"text-align: center; padding-bottom: 20px;\"><img src=\"(.*?)\".*?class=\"print\">", RegexOptions.Singleline).Match(sHtml);

                Pic p = new Pic();
                p.PicUrl = "http://www.coloring-book.info/coloring/" + mPic.Groups[1].Value;
                p.FileName = mPic.Groups[1].Value.Substring(mPic.Groups[1].Value.LastIndexOf('/') + 1);
                p.ThumbsUrl = "http://www.coloring-book.info/coloring/" + m.Groups[2].Value; ;
                listPic.Add(p);

            }


            foreach (Pic p in listPic)
            {
                try
                {
                    p.DownloadPic(sPath);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }

            }


        }

    }
}
