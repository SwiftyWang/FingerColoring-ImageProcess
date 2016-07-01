using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace SecretGarden
{
    class Collector
    {

        public static void DownloadPic(string sPath)
        {

            WebClient wc = new WebClient();
            string sHtml = wc.DownloadString(@"http://www.coloring-book.info/coloring/");

            Regex reg = new Regex("<td.*?width=\"33%\".*?valign=\"bottom\">.*?<a.*?href=\"(.*?)\".*?<b>(.*?)</b>", RegexOptions.Singleline);
            MatchCollection mc = reg.Matches(sHtml);

            string sUrlHead = "http://www.coloring-book.info/coloring/";

            List<PicPage> listPage = new List<PicPage>();
            foreach (Match m in mc)
            {
                PicPage picPage = new PicPage();
                picPage.sPageUrl = sUrlHead + m.Groups[1].Value;
                picPage.sCategory = m.Groups[2].Value.Replace(":", "");
                listPage.Add(picPage);
            }

            foreach (PicPage page in listPage)
            {
                string sFolder = sPath + "\\" + page.sCategory;
                if (!Directory.Exists(sFolder))
                {
                    Directory.CreateDirectory(sFolder);
                }
                page.DownloadPics(sFolder);

            }

        }

    }
}
