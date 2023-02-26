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

        /* hybrid-analysis */
        /*
        private async void InitializeWebView2()
        {
            await webView21.EnsureCoreWebView2Async();

            webView21.CoreWebView2.DOMContentLoaded += CoreWebView2_DOMContentLoaded;
            webView21.CoreWebView2.Navigate("https://www.hybrid-analysis.com/submissions/sandbox/files");
        }

        private async void CoreWebView2_DOMContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e)
        {
            await webView21.ExecuteScriptAsync("document.querySelector('.mat-select-arrow-wrapper').click();");
            await Task.Delay(1000);
            await webView21.ExecuteScriptAsync("document.querySelector('.mat-option-text[value=\"100\"]').click();");
            await Task.Delay(1000);
            await webView21.ExecuteScriptAsync("document.querySelector('.fa-file-alt').click();");
        }

        private async void webView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        { 
            string uri = webView.Source.ToString();
            //if (e.IsSuccess && e.HttpStatusCode == 200 && uri == new Uri("https://www.hybrid-analysis.com/submissions/sandbox/files"))
            if (e.IsSuccess && e.HttpStatusCode == 200)
            {
                string html = await webView21.ExecuteScriptAsync("document.documentElement.outerHTML");

                string filePath = Path.Combine(Application.StartupPath, "result.html");

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    await sw.WriteAsync(html);
                }

                MessageBox.Show("결과문이 " + filePath + " 에 저장되었습니다.");
            }
        }
        */
    }
}
