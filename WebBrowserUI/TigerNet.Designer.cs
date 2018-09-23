namespace WebBrowserUI
{
     partial class TigerNet
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

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.webBrowser1 = new System.Windows.Forms.WebBrowser();
               this.tabControl1 = new System.Windows.Forms.TabControl();
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.savePageAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
               this.exitWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.manageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.manageBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.webNavigationControl1 = new WebBrowserUI.WebNavigationControl();
               this.tabPage1.SuspendLayout();
               this.tabControl1.SuspendLayout();
               this.menuStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // tabPage1
               // 
               this.tabPage1.Controls.Add(this.webNavigationControl1);
               this.tabPage1.Controls.Add(this.webBrowser1);
               this.tabPage1.Location = new System.Drawing.Point(4, 22);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(942, 428);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "tabPage1";
               this.tabPage1.UseVisualStyleBackColor = true;
               // 
               // webBrowser1
               // 
               this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.webBrowser1.Location = new System.Drawing.Point(3, 3);
               this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
               this.webBrowser1.Name = "webBrowser1";
               this.webBrowser1.Size = new System.Drawing.Size(936, 422);
               this.webBrowser1.TabIndex = 0;
               // 
               // tabControl1
               // 
               this.tabControl1.Controls.Add(this.tabPage1);
               this.tabControl1.Location = new System.Drawing.Point(3, 27);
               this.tabControl1.Name = "tabControl1";
               this.tabControl1.SelectedIndex = 0;
               this.tabControl1.Size = new System.Drawing.Size(950, 454);
               this.tabControl1.TabIndex = 2;
               // 
               // menuStrip1
               // 
               this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(965, 24);
               this.menuStrip1.TabIndex = 3;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeCurrentTabToolStripMenuItem,
            this.savePageAsHTMLToolStripMenuItem,
            this.printPageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitWebBrowserToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
               this.fileToolStripMenuItem.Text = "File";
               // 
               // newTabToolStripMenuItem
               // 
               this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
               this.newTabToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.newTabToolStripMenuItem.Text = "New Tab";
               this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
               // 
               // closeCurrentTabToolStripMenuItem
               // 
               this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
               this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab";
               this.closeCurrentTabToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentTabToolStripMenuItem_Click);
               // 
               // savePageAsHTMLToolStripMenuItem
               // 
               this.savePageAsHTMLToolStripMenuItem.Name = "savePageAsHTMLToolStripMenuItem";
               this.savePageAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.savePageAsHTMLToolStripMenuItem.Text = "Save Page As HTML";
               // 
               // printPageToolStripMenuItem
               // 
               this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
               this.printPageToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.printPageToolStripMenuItem.Text = "Print Page";
               // 
               // toolStripSeparator1
               // 
               this.toolStripSeparator1.Name = "toolStripSeparator1";
               this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
               // 
               // exitWebBrowserToolStripMenuItem
               // 
               this.exitWebBrowserToolStripMenuItem.Name = "exitWebBrowserToolStripMenuItem";
               this.exitWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.exitWebBrowserToolStripMenuItem.Text = "Exit Web Browser";
               this.exitWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitWebBrowserToolStripMenuItem_Click);
               // 
               // toolsToolStripMenuItem
               // 
               this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryToolStripMenuItem,
            this.manageBookmarksToolStripMenuItem});
               this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
               this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
               this.toolsToolStripMenuItem.Text = "Tools";
               // 
               // manageHistoryToolStripMenuItem
               // 
               this.manageHistoryToolStripMenuItem.Name = "manageHistoryToolStripMenuItem";
               this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.manageHistoryToolStripMenuItem.Text = "Manage History";
               this.manageHistoryToolStripMenuItem.Click += new System.EventHandler(this.manageHistoryToolStripMenuItem_Click);
               // 
               // manageBookmarksToolStripMenuItem
               // 
               this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
               this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
               this.manageBookmarksToolStripMenuItem.Click += new System.EventHandler(this.manageBookmarksToolStripMenuItem_Click);
               // 
               // helpToolStripMenuItem
               // 
               this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
               this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
               this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
               this.helpToolStripMenuItem.Text = "Help";
               // 
               // aboutToolStripMenuItem
               // 
               this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
               this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
               this.aboutToolStripMenuItem.Text = "About";
               this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
               // 
               // webNavigationControl1
               // 
               this.webNavigationControl1.Location = new System.Drawing.Point(3, 3);
               this.webNavigationControl1.Name = "webNavigationControl1";
               this.webNavigationControl1.Size = new System.Drawing.Size(919, 419);
               this.webNavigationControl1.TabIndex = 1;
               // 
               // TigerNet
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(965, 493);
               this.Controls.Add(this.menuStrip1);
               this.Controls.Add(this.tabControl1);
               this.Name = "TigerNet";
               this.Text = "TigerNet";
               this.tabPage1.ResumeLayout(false);
               this.tabControl1.ResumeLayout(false);
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          public System.Windows.Forms.TabPage tabPage1;
          private System.Windows.Forms.WebBrowser webBrowser1;
          public System.Windows.Forms.TabControl tabControl1;
          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem savePageAsHTMLToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
          private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
          private System.Windows.Forms.ToolStripMenuItem exitWebBrowserToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
          private WebNavigationControl webNavigationControl1;
     }
}