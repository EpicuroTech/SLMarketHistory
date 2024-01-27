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

namespace SplinterlandsMarketTrack
{
    public partial class Form2 : Form
    {
        //private WebBrowser webBrowser1;
        public Form2()
        {
            InitializeComponent();
            LoadHtmlContent();
        }
        private void LoadHtmlContent()
        {
            var page = File.ReadAllText(@"..\..\Data\HistoryInHTML.html");
            webBrowser1.DocumentText = page;
        }

    }
}
