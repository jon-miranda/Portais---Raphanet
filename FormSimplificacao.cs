﻿using System;
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
    public partial class FormSimplificacao : Form
    {
        WebView2 webView2;
        public FormSimplificacao()
        {
            InitializeComponent();
            webView2 = new WebView2();

            webView2.Dock = DockStyle.Fill;
            Controls.Add(webView2);

            webView2.Source = new Uri("https://suporte.simplificacao.com/otrs/customer.pl?Action=Logout");
        }
    }
}
