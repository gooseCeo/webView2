using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowser
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
