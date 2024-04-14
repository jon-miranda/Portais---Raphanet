using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Test_Winforms_e_Selenium
{
    public partial class FormPortalSkyone : Form
    {
        WebView2 webViewer2;
        public FormPortalSkyone()
        {
            InitializeComponent();

            webViewer2 = new WebView2();
            webViewer2.Dock = DockStyle.Fill;

            Controls.Add(webViewer2);

            webViewer2.Source = new Uri("https://portal.skyone.cloud/");
        }
    }
}
