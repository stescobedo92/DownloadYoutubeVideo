using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DownloadYoutubeVideo
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkin.MaterialSkinManager _materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            _materialSkinManager.EnforceBackcolorOnAllComponents = true;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100,MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

    }
}
