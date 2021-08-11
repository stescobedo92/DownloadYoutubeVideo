
namespace DownloadYoutubeVideo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.materialLblSpeed = new MaterialSkin.Controls.MaterialLabel();
            this.lblSpeed = new MaterialSkin.Controls.MaterialLabel();
            this.lblDownloaded = new MaterialSkin.Controls.MaterialLabel();
            this.labelDownload = new MaterialSkin.Controls.MaterialLabel();
            this.btnResume = new MaterialSkin.Controls.MaterialButton();
            this.btnPause = new MaterialSkin.Controls.MaterialButton();
            this.percentLabel = new MaterialSkin.Controls.MaterialLabel();
            this.progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.statusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUrl = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.tabOnlineSupport = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabHome);
            this.materialTabControl1.Controls.Add(this.tabUser);
            this.materialTabControl1.Controls.Add(this.tabOnlineSupport);
            this.materialTabControl1.Controls.Add(this.tabSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(715, 407);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.materialLblSpeed);
            this.tabHome.Controls.Add(this.lblSpeed);
            this.tabHome.Controls.Add(this.lblDownloaded);
            this.tabHome.Controls.Add(this.labelDownload);
            this.tabHome.Controls.Add(this.btnResume);
            this.tabHome.Controls.Add(this.btnPause);
            this.tabHome.Controls.Add(this.percentLabel);
            this.tabHome.Controls.Add(this.progressBar);
            this.tabHome.Controls.Add(this.statusLabel);
            this.tabHome.Controls.Add(this.materialLabel2);
            this.tabHome.Controls.Add(this.txtUrl);
            this.tabHome.Controls.Add(this.materialLabel1);
            this.tabHome.Controls.Add(this.btnStart);
            this.tabHome.ImageKey = "home_32px.png";
            this.tabHome.Location = new System.Drawing.Point(4, 39);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(707, 364);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.Click += new System.EventHandler(this.tabHome_Click);
            // 
            // materialLblSpeed
            // 
            this.materialLblSpeed.AutoSize = true;
            this.materialLblSpeed.Depth = 0;
            this.materialLblSpeed.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLblSpeed.Location = new System.Drawing.Point(120, 184);
            this.materialLblSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLblSpeed.Name = "materialLblSpeed";
            this.materialLblSpeed.Size = new System.Drawing.Size(53, 19);
            this.materialLblSpeed.TabIndex = 12;
            this.materialLblSpeed.Text = "0 MB/s";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Depth = 0;
            this.lblSpeed.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSpeed.Location = new System.Drawing.Point(64, 183);
            this.lblSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(49, 19);
            this.lblSpeed.TabIndex = 11;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblDownloaded
            // 
            this.lblDownloaded.AutoSize = true;
            this.lblDownloaded.Depth = 0;
            this.lblDownloaded.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDownloaded.Location = new System.Drawing.Point(119, 157);
            this.lblDownloaded.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDownloaded.Name = "lblDownloaded";
            this.lblDownloaded.Size = new System.Drawing.Size(38, 19);
            this.lblDownloaded.TabIndex = 10;
            this.lblDownloaded.Text = "0 MB";
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Depth = 0;
            this.labelDownload.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDownload.Location = new System.Drawing.Point(19, 157);
            this.labelDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(94, 19);
            this.labelDownload.TabIndex = 9;
            this.labelDownload.Text = "Downloaded:";
            // 
            // btnResume
            // 
            this.btnResume.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResume.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResume.Depth = 0;
            this.btnResume.HighEmphasis = true;
            this.btnResume.Icon = null;
            this.btnResume.Location = new System.Drawing.Point(600, 147);
            this.btnResume.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResume.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(88, 36);
            this.btnResume.TabIndex = 8;
            this.btnResume.Text = "&Resume";
            this.btnResume.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResume.UseAccentColor = false;
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPause.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPause.Depth = 0;
            this.btnPause.HighEmphasis = true;
            this.btnPause.Icon = null;
            this.btnPause.Location = new System.Drawing.Point(516, 147);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(76, 36);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "&Pause";
            this.btnPause.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPause.UseAccentColor = false;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Depth = 0;
            this.percentLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.percentLabel.Location = new System.Drawing.Point(654, 101);
            this.percentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(22, 19);
            this.percentLabel.TabIndex = 6;
            this.percentLabel.Text = "0%";
            // 
            // progressBar
            // 
            this.progressBar.Depth = 0;
            this.progressBar.Location = new System.Drawing.Point(79, 123);
            this.progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(600, 5);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Depth = 0;
            this.statusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusLabel.Location = new System.Drawing.Point(81, 87);
            this.statusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(25, 19);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "???";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(16, 87);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Status:";
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.White;
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.Depth = 0;
            this.txtUrl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrl.LeadingIcon = null;
            this.txtUrl.Location = new System.Drawing.Point(79, 9);
            this.txtUrl.MaxLength = 50;
            this.txtUrl.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUrl.Multiline = false;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(600, 50);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "";
            this.txtUrl.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(42, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(28, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Url: ";
            // 
            // btnStart
            // 
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStart.Depth = 0;
            this.btnStart.HighEmphasis = true;
            this.btnStart.Icon = null;
            this.btnStart.Location = new System.Drawing.Point(432, 147);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStart.UseAccentColor = false;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.Color.White;
            this.tabUser.ImageKey = "add_user_male_32px.png";
            this.tabUser.Location = new System.Drawing.Point(4, 39);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(707, 364);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            // 
            // tabOnlineSupport
            // 
            this.tabOnlineSupport.BackColor = System.Drawing.Color.White;
            this.tabOnlineSupport.ImageKey = "online_support_32px.png";
            this.tabOnlineSupport.Location = new System.Drawing.Point(4, 39);
            this.tabOnlineSupport.Name = "tabOnlineSupport";
            this.tabOnlineSupport.Size = new System.Drawing.Size(707, 364);
            this.tabOnlineSupport.TabIndex = 2;
            this.tabOnlineSupport.Text = "Online Support";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.ImageKey = "settings_32px.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(707, 364);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add_user_male_32px.png");
            this.imageList1.Images.SetKeyName(1, "home_32px.png");
            this.imageList1.Images.SetKeyName(2, "online_support_32px.png");
            this.imageList1.Images.SetKeyName(3, "settings_32px.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 474);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Youtube Video";
            this.materialTabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabOnlineSupport;
        private System.Windows.Forms.TabPage tabSettings;
        private MaterialSkin.Controls.MaterialTextBox txtUrl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnStart;
        private MaterialSkin.Controls.MaterialButton btnPause;
        private MaterialSkin.Controls.MaterialLabel percentLabel;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel statusLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnResume;
        private MaterialSkin.Controls.MaterialLabel materialLblSpeed;
        private MaterialSkin.Controls.MaterialLabel lblSpeed;
        private MaterialSkin.Controls.MaterialLabel lblDownloaded;
        private MaterialSkin.Controls.MaterialLabel labelDownload;
    }
}

