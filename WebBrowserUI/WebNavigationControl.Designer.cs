namespace WebBrowserUI
{
     partial class WebNavigationControl
     {
          /// <summary> 
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary> 
          /// Clean up any resources being used.
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebNavigationControl));
               this.toolStrip1 = new System.Windows.Forms.ToolStrip();
               this.BackButton = new System.Windows.Forms.ToolStripButton();
               this.FowardButton = new System.Windows.Forms.ToolStripButton();
               this.RefreshButton = new System.Windows.Forms.ToolStripButton();
               this.HomeButton = new System.Windows.Forms.ToolStripButton();
               this.AddressTextBox = new System.Windows.Forms.ToolStripTextBox();
               this.GoButton = new System.Windows.Forms.ToolStripButton();
               this.Bookmark = new System.Windows.Forms.ToolStripButton();
               this.webBrowser1 = new System.Windows.Forms.WebBrowser();
               this.statusStrip1 = new System.Windows.Forms.StatusStrip();
               this.toolStripProgressBarLoading = new System.Windows.Forms.ToolStripProgressBar();
               this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
               this.timer1 = new System.Windows.Forms.Timer(this.components);
               this.toolStrip1.SuspendLayout();
               this.statusStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // toolStrip1
               // 
               this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.FowardButton,
            this.RefreshButton,
            this.HomeButton,
            this.AddressTextBox,
            this.GoButton,
            this.Bookmark});
               this.toolStrip1.Location = new System.Drawing.Point(0, 0);
               this.toolStrip1.Name = "toolStrip1";
               this.toolStrip1.Size = new System.Drawing.Size(866, 25);
               this.toolStrip1.TabIndex = 2;
               this.toolStrip1.Text = "toolStrip1";
               // 
               // BackButton
               // 
               this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
               this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.BackButton.Name = "BackButton";
               this.BackButton.Size = new System.Drawing.Size(23, 22);
               this.BackButton.Text = "Back";
               this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
               // 
               // FowardButton
               // 
               this.FowardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.FowardButton.Image = ((System.Drawing.Image)(resources.GetObject("FowardButton.Image")));
               this.FowardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.FowardButton.Name = "FowardButton";
               this.FowardButton.Size = new System.Drawing.Size(23, 22);
               this.FowardButton.Text = "Forward";
               this.FowardButton.Click += new System.EventHandler(this.FowardButton_Click);
               // 
               // RefreshButton
               // 
               this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
               this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.RefreshButton.Name = "RefreshButton";
               this.RefreshButton.Size = new System.Drawing.Size(23, 22);
               this.RefreshButton.Text = "Refresh";
               this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
               // 
               // HomeButton
               // 
               this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
               this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.HomeButton.Name = "HomeButton";
               this.HomeButton.Size = new System.Drawing.Size(23, 22);
               this.HomeButton.Text = "Home";
               // 
               // AddressTextBox
               // 
               this.AddressTextBox.Name = "AddressTextBox";
               this.AddressTextBox.Size = new System.Drawing.Size(700, 25);
               this.AddressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressTextBox_KeyDown);
               // 
               // GoButton
               // 
               this.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.GoButton.Image = ((System.Drawing.Image)(resources.GetObject("GoButton.Image")));
               this.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.GoButton.Name = "GoButton";
               this.GoButton.Size = new System.Drawing.Size(23, 22);
               this.GoButton.Text = "Go";
               this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
               // 
               // Bookmark
               // 
               this.Bookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.Bookmark.Image = ((System.Drawing.Image)(resources.GetObject("Bookmark.Image")));
               this.Bookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.Bookmark.Name = "Bookmark";
               this.Bookmark.Size = new System.Drawing.Size(23, 22);
               this.Bookmark.Text = "Bookmark Page";
               this.Bookmark.Click += new System.EventHandler(this.Bookmark_Click);
               // 
               // webBrowser1
               // 
               this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.webBrowser1.Location = new System.Drawing.Point(0, 25);
               this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
               this.webBrowser1.Name = "webBrowser1";
               this.webBrowser1.Size = new System.Drawing.Size(866, 561);
               this.webBrowser1.TabIndex = 3;
               this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
               // 
               // statusStrip1
               // 
               this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
               this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarLoading,
            this.toolStripStatusLabel1});
               this.statusStrip1.Location = new System.Drawing.Point(0, 25);
               this.statusStrip1.Name = "statusStrip1";
               this.statusStrip1.Size = new System.Drawing.Size(866, 22);
               this.statusStrip1.TabIndex = 4;
               this.statusStrip1.Text = "statusStrip1";
               // 
               // toolStripProgressBarLoading
               // 
               this.toolStripProgressBarLoading.Name = "toolStripProgressBarLoading";
               this.toolStripProgressBarLoading.Size = new System.Drawing.Size(250, 16);
               this.toolStripProgressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
               // 
               // toolStripStatusLabel1
               // 
               this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
               this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
               // 
               // timer1
               // 
               this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
               // 
               // WebNavigationControl
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.statusStrip1);
               this.Controls.Add(this.webBrowser1);
               this.Controls.Add(this.toolStrip1);
               this.Name = "WebNavigationControl";
               this.Size = new System.Drawing.Size(866, 586);
               this.toolStrip1.ResumeLayout(false);
               this.toolStrip1.PerformLayout();
               this.statusStrip1.ResumeLayout(false);
               this.statusStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.ToolStripButton BackButton;
          private System.Windows.Forms.ToolStripButton FowardButton;
          private System.Windows.Forms.ToolStripButton RefreshButton;
          private System.Windows.Forms.ToolStripButton HomeButton;
          private System.Windows.Forms.ToolStripTextBox AddressTextBox;
          private System.Windows.Forms.ToolStripButton GoButton;
          private System.Windows.Forms.ToolStripButton Bookmark;
          private System.Windows.Forms.WebBrowser webBrowser1;
          private System.Windows.Forms.StatusStrip statusStrip1;
          public System.Windows.Forms.ToolStripProgressBar toolStripProgressBarLoading;
          private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
          public System.Windows.Forms.Timer timer1;
     }
}
