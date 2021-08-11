using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;
using MaterialSkin.Controls;

namespace DownloadYoutubeVideo
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkin.MaterialSkinManager _materialSkinManager;
        private HttpDownloader _httpDownloader;
        public Form1()
        {
            InitializeComponent();
            _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            _materialSkinManager.EnforceBackcolorOnAllComponents = true;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100,MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void tabHome_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _httpDownloader = new HttpDownloader(txtUrl.Text, $"{Application.StartupPath}\\{Path.GetFileName(txtUrl.Text)}");
            _httpDownloader.DownloadCompleted += HttpDownloader_DownloadComplete;
            _httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            _httpDownloader.Start();

        }

        private void HttpDownloader_DownloadComplete(object sender, EventArgs e) 
        {
            this.Invoke((MethodInvoker)delegate 
            {
                statusLabel.Text = "Finish !!";
                percentLabel.Text = "100%";
            });
        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.Progress;
            percentLabel.Text = $"{e.Progress.ToString("0.00")} %";
            materialLblSpeed.Text = string.Format("{0} MB/s",(e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            lblDownloaded.Text = string.Format("{0} MB/s", (_httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            statusLabel.Text = "Downloading...";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(_httpDownloader != null)
            {
                _httpDownloader.Pause();
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (_httpDownloader != null)
            {
                _httpDownloader.Resume();
            }
        }
    }
}
