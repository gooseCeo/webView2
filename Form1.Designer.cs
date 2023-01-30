
namespace webBrowser
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.url = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.fYoutube = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(83, 0);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(723, 21);
            this.url.TabIndex = 1;
            this.url.MouseClick += new System.Windows.Forms.MouseEventHandler(this.url_MouseClick);
            this.url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.url_KeyDown);
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(812, 0);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 2;
            this.go.Text = "이동";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 23);
            this.back.TabIndex = 3;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(36, 0);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(30, 23);
            this.forward.TabIndex = 4;
            this.forward.Text = ">";
            this.forward.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(985, 629);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // fYoutube
            // 
            this.fYoutube.Location = new System.Drawing.Point(893, 0);
            this.fYoutube.Name = "fYoutube";
            this.fYoutube.Size = new System.Drawing.Size(75, 23);
            this.fYoutube.TabIndex = 6;
            this.fYoutube.Text = "유투브";
            this.fYoutube.UseVisualStyleBackColor = true;
            this.fYoutube.Click += new System.EventHandler(this.fYoutube_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 629);
            this.Controls.Add(this.fYoutube);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.go);
            this.Controls.Add(this.url);
            this.Controls.Add(this.webView21);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button fYoutube;
    }
}

