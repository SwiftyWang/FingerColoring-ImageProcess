using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace SecretGarden
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tbOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                tbOutputPath.Text = folder.SelectedPath;
            }
        }

        private void btnBeginCollect_Click(object sender, EventArgs e)
        {
            Collector.DownloadPic(tbOutputPath.Text);
        }

        private void tbPicPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                tbPicPath.Text = folder.SelectedPath;
                PicProcess.PicFilePath = new List<string>();
                PicProcess.PicFilePath.AddRange(Directory.GetFiles(tbPicPath.Text, "*.jpg"));
            }
        }

        private void btnTestOne_Click(object sender, EventArgs e)
        {
            //Use the first one as an example

            string sPath = PicProcess.PicFilePath[0];
            Bitmap bm = Image.FromFile(sPath) as Bitmap;
            pic1.Image = bm;
            Rectangle rect = new Rectangle(0, 0, bm.Size.Width, bm.Size.Height);
            PixelFormat format = bm.PixelFormat;
            Bitmap bm2 = bm.Clone(rect, format);

            pic2.Image = PicProcess.DropNoise(bm2);

            bm2.Save(sPath + ".png", ImageFormat.Png);

        }

        private void btnProcessPic_Click(object sender, EventArgs e)
        {
            //First get Category List
            List<PicCategory> listCategory = PicProcess.GetCategory(tbPicPath.Text, 350);
            PicProcess.ProcessCategory(tbPicPath.Text, listCategory);
        }

        private void btnCollectDirectory_Click(object sender, EventArgs e)
        {
            //Get the DictFile
            string[] reads = File.ReadAllLines(tbPicPath.Text + "\\Translate.txt");
            Dictionary<string, string> mapName = new Dictionary<string, string>();
            foreach (string r in reads)
            {
                string[] ss = r.Split('|');
                mapName[ss[0]] = ss[1];
            }

            DirectoryInfo info = new DirectoryInfo(tbPicPath.Text + "_processed");
            DirectoryInfo[] dirs = info.GetDirectories();
            Dictionary<int, PicCategory> mapDir = new Dictionary<int, PicCategory>();
            foreach (DirectoryInfo inf in dirs)
            {
                string[] ss = inf.Name.Split('_');

                PicCategory c = new PicCategory();
                c.ID = Int32.Parse(ss[1]);
                c.SortID = Int32.Parse(ss[2]);
                c.EName = ss[0];
                if (mapName.ContainsKey(ss[0]))
                {
                    c.CName = mapName[ss[0]];
                }
                else
                {
                    c.CName = c.EName;
                }
                c.SrcPath = inf.FullName;
                mapDir[c.SortID] = c;
            }

            string sNewPath = tbPicPath.Text + "_Output";

            Directory.CreateDirectory(sNewPath);

            string sJson = "[";

            //Change the order!
            int iMaxSortID = mapDir.Count;


            for (int iCur = 0; iCur < iMaxSortID; iCur++)
            {
                PicCategory c = mapDir[iCur];
                string sCatPath = sNewPath + "\\" + c.ID;
                Directory.CreateDirectory(sCatPath);

                FileInfo[] fileNames = new DirectoryInfo(c.SrcPath).GetFiles();
                int iCnt = (fileNames.Length - 1) / 2;

                sJson += "{c:" + c.ID + ",n:'" + c.CName.Replace("\'", "\\\'") + "',max:" + iCnt.ToString() + "},";

                foreach (FileInfo fInfo in fileNames)
                {
                    if (fInfo.Name == "category.gif")
                    {
                        Bitmap bm = Bitmap.FromFile(fInfo.FullName) as Bitmap;
                        bm.Save(sCatPath + "\\category.png", ImageFormat.Png);
                    }
                    else
                    {
                        fInfo.CopyTo(sCatPath + "\\" + fInfo.Name);
                    }
                }

            }

            sJson = sJson.Substring(0, sJson.Length - 1);
            sJson += "]";

            File.WriteAllText(sNewPath + "\\Category.txt", sJson);


        }

        private void btnAddLock_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(tbPicPath.Text + "_Output");
            DirectoryInfo[] dirs = info.GetDirectories();
            foreach (DirectoryInfo inf in dirs)
            {

                FileInfo[] files = inf.GetFiles();
                foreach (FileInfo f in files)
                {
                    if (!f.Name.StartsWith("f_"))
                    {
                        continue;
                    }

                    //make it grey


                    ImageHelper.Brightness(f.FullName, f.FullName.Replace("f_", "l_"), 0.5F);



                }


            }
        }

        private void tbOutputPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
