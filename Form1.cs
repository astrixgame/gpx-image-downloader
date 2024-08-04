using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GPX_Image_Exporter
{
    public partial class Form1 : Form
    {
        public static List<ImagePlace> imageList = new List<ImagePlace>();

        public Form1()
        {
            InitializeComponent();
        }

        private void chpath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = !radio_singleFile.Checked;
            dialog.Multiselect = true;
            dialog.Title = "Select GPX "+(dialog.IsFolderPicker == true ? "Folders" : "Files");

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                imageList.Clear();
                loadedFiles.Items.Clear();
                pathSelected.Text = String.Join(";", dialog.FileNames.ToList());

                if (dialog.IsFolderPicker)
                    foreach (var file in new DirectoryInfo(dialog.FileName).GetFiles("*.gpx"))
                    {
                        loadImages(file.FullName);
                    }
                else
                    foreach(string file in dialog.FileNames)
                        loadImages(file);
            }
            images_text.Text = "Loaded images: (" + imageList.Count() + ")";
            updateEn();
        }

        public void loadImages(string gpxPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(gpxPath);

            XmlNamespaceManager namespaceManager = new XmlNamespaceManager(doc.NameTable);
            namespaceManager.AddNamespace("ns", "http://www.topografix.com/GPX/1/0");

            foreach (XmlNode loc in doc.GetElementsByTagName("wpt"))
            {
                XmlNodeList imgs = loc.SelectNodes("ns:cmt", namespaceManager);
                var i = 0;
                foreach(XmlNode img in imgs)
                    if (img != null && img.InnerText.Contains("mymaps.usercontent.google.com"))
                    {
                        string placeName = loc.SelectSingleNode("ns:name", namespaceManager).InnerText;
                        var imgp = new ImagePlace();
                        imgp.GPXName = System.IO.Path.GetFileName(gpxPath).Replace(".gpx", "");
                        imgp.PlaceName = placeName+(i == 0 ? "" : " "+i.ToString());
                        imgp.URL = getStrBetween(img.InnerText, "src=\";", "\" height");
                        imageList.Add(imgp);
                        loadedFiles.Items.Add(placeName);
                        
                        i++;
                    }
            }
        }

        public string getStrBetween(string str, string fStr, string lStr)
        {
            string rStr;
            int p1 = str.IndexOf(fStr) + fStr.Length;
            int p2 = str.IndexOf(lStr);
            var s1 = p1 + fStr.Length;
            if(p2 > 0)
                p2 -= lStr.Length + 2;
            if (s1 > 0)
                s1 -= 1;
            rStr = str.Substring(s1, p2);
            return rStr;
        }

        private void destSelect_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;
            dialog.Title = "Select GPX " + (dialog.IsFolderPicker == true ? "Folders" : "Files");

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                destinationPath.Text = String.Join(";", dialog.FileNames.ToList());
                openFolder.Enabled = true;
                updateEn();
            }
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", destinationPath.Text);
        }

        public void updateEn()
        {
            if (loadedFiles.Items.Count > 0 && openFolder.Enabled == true)
            {
                ssbtn.Enabled = true;
            }
        }

        private void ssbtn_Click(object sender, EventArgs e)
        {
            if (thread1.IsBusy)
            {
                thread1.CancelAsync();
                ssbtn.Text = "Start";
                progressBar1.Value = 0;
                chpath.Enabled = false;
                destinationPath.Enabled = false;
                log("Download canceled");
            } else
            {
                thread1.RunWorkerAsync();
                chpath.Enabled = true;
                destinationPath.Enabled = true;
                ssbtn.Text = "Stop";
                progressBar1.Value = 0;
                log("Download started");
            }
                
        }

        public void log(string message)
        {
            logList.Items.Add("[" + DateTime.Now.ToString("hh:mm:ss") + "]: " + message);
            logList.TopIndex = logList.Items.Count - 1;
        }

        private void thread1_DoWork(object sender, DoWorkEventArgs e)
        {
            var n = 0;
            using (var client = new WebClient())
                foreach (ImagePlace imgp in imageList)
                {
                    n += 100;
                    string pth = (destinationPath.Text.Replace("\\", "/") + "/" + imgp.GPXName).Trim(Path.GetInvalidFileNameChars()).Trim(Path.GetInvalidPathChars()).Replace("?", "");
                    if (!Directory.Exists(pth))
                        Directory.CreateDirectory(pth);
                    pth = (pth + "/" + imgp.PlaceName).Trim(Path.GetInvalidFileNameChars()).Trim(Path.GetInvalidPathChars()).Replace("?", "");

                    client.DownloadFile(imgp.URL, pth);
                    if(!File.Exists(pth + ".png"))
                        System.IO.File.Move(pth, pth + ".png");
                    if(File.Exists(pth))
                        System.IO.File.Delete(pth);
                    this.Invoke(new MethodInvoker(delegate {
                        logList.Items.Add("[" + DateTime.Now.ToString("hh:mm:ss") + "]: Saved " + imgp.PlaceName);
                        logList.TopIndex = logList.Items.Count - 1;
                        progressBar1.Value = n / imageList.Count();
                    }));
                }
        }

        private void threadFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            ssbtn.Text = "Start";
            chpath.Enabled = true;
            destinationPath.Enabled = true;
            log("Download finished");
        }

        private void logList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class ImagePlace
    {
        public string GPXName { get; set; }
        public string PlaceName { get; set; }
        public string URL {  get; set; }
    }
}
