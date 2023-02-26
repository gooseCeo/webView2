using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace webBrowser
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWebView2();
        }

        private async void InitializeWebView2()
        {
            await webView21.EnsureCoreWebView2Async();

            webView21.CoreWebView2.DOMContentLoaded += CoreWebView2_DOMContentLoaded;
            webView21.CoreWebView2.Navigate("https://www.hybrid-analysis.com/login");
        }

        private async void CoreWebView2_DOMContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e)
        {
            //await webView21.ExecuteScriptAsync("document.getElementById('login_username').value = 'my_username'; document.getElementById('login_password').value = 'my_password'; document.getElementById('login_form').submit();");
            await webView21.ExecuteScriptAsync("document.getElementById('login_email').value = 'my_username'; document.getElementById('login_password').value = 'my_password';document.getElementById('login-form').submit(); ");
            webView21.CoreWebView2.DOMContentLoaded -= CoreWebView2_DOMContentLoaded;
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void url_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                await webView21.EnsureCoreWebView2Async();
                webView21.CoreWebView2.Navigate(url.Text);
            }
        }

        private void url_MouseClick(object sender, MouseEventArgs e)
        {
            url.Text = "https://";
        }

        private async void fYoutube_Click(object sender, EventArgs e)
        {
            url.Text = "https://www.youtube.com/";
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate(url.Text);
        }

        private async void go_Click(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate(url.Text);
        }
    }
}
