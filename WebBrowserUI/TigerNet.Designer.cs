﻿namespace WebBrowserUI
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TigerNet));
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.savePageAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.exitWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.manageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.manageBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
               this.toolStrip1 = new System.Windows.Forms.ToolStrip();
               this.BackButton = new System.Windows.Forms.ToolStripButton();
               this.FowardButton = new System.Windows.Forms.ToolStripButton();
               this.RefreshButton = new System.Windows.Forms.ToolStripButton();
               this.HomeButton = new System.Windows.Forms.ToolStripButton();
               this.AddressTextBox = new System.Windows.Forms.ToolStripTextBox();
               this.GoButton = new System.Windows.Forms.ToolStripButton();
               this.Bookmark = new System.Windows.Forms.ToolStripButton();
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.tabControl1 = new System.Windows.Forms.TabControl();
               this.webBrowser1 = new System.Windows.Forms.WebBrowser();
               this.menuStrip1.SuspendLayout();
               this.toolStrip1.SuspendLayout();
               this.tabPage1.SuspendLayout();
               this.tabControl1.SuspendLayout();
               this.SuspendLayout();
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
               this.menuStrip1.Size = new System.Drawing.Size(882, 24);
               this.menuStrip1.TabIndex = 0;
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
               // toolsToolStripMenuItem
               // 
               this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryToolStripMenuItem,
            this.manageBookmarksToolStripMenuItem});
               this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
               this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
               this.toolsToolStripMenuItem.Text = "Tools";
               // 
               // helpToolStripMenuItem
               // 
               this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
               this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
               this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
               this.helpToolStripMenuItem.Text = "Help";
               // 
               // newTabToolStripMenuItem
               // 
               this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
               this.newTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.newTabToolStripMenuItem.Text = "New Tab";
               // 
               // closeCurrentTabToolStripMenuItem
               // 
               this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
               this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab";
               // 
               // savePageAsHTMLToolStripMenuItem
               // 
               this.savePageAsHTMLToolStripMenuItem.Name = "savePageAsHTMLToolStripMenuItem";
               this.savePageAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.savePageAsHTMLToolStripMenuItem.Text = "Save Page As HTML";
               // 
               // printPageToolStripMenuItem
               // 
               this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
               this.printPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.printPageToolStripMenuItem.Text = "Print Page";
               // 
               // exitWebBrowserToolStripMenuItem
               // 
               this.exitWebBrowserToolStripMenuItem.Name = "exitWebBrowserToolStripMenuItem";
               this.exitWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.exitWebBrowserToolStripMenuItem.Text = "Exit Web Browser";
               this.exitWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitWebBrowserToolStripMenuItem_Click);
               // 
               // manageHistoryToolStripMenuItem
               // 
               this.manageHistoryToolStripMenuItem.Name = "manageHistoryToolStripMenuItem";
               this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.manageHistoryToolStripMenuItem.Text = "Manage History";
               // 
               // manageBookmarksToolStripMenuItem
               // 
               this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
               this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
               // 
               // aboutToolStripMenuItem
               // 
               this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
               this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.aboutToolStripMenuItem.Text = "About";
               this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
               // 
               // toolStripSeparator1
               // 
               this.toolStripSeparator1.Name = "toolStripSeparator1";
               this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
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
               this.toolStrip1.Location = new System.Drawing.Point(0, 24);
               this.toolStrip1.Name = "toolStrip1";
               this.toolStrip1.Size = new System.Drawing.Size(882, 25);
               this.toolStrip1.TabIndex = 1;
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
               // 
               // FowardButton
               // 
               this.FowardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.FowardButton.Image = ((System.Drawing.Image)(resources.GetObject("FowardButton.Image")));
               this.FowardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.FowardButton.Name = "FowardButton";
               this.FowardButton.Size = new System.Drawing.Size(23, 22);
               this.FowardButton.Text = "Forward";
               // 
               // RefreshButton
               // 
               this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
               this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.RefreshButton.Name = "RefreshButton";
               this.RefreshButton.Size = new System.Drawing.Size(23, 22);
               this.RefreshButton.Text = "Refresh";
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
               this.AddressTextBox.Click += new System.EventHandler(this.AddressTextBox_Click);
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
               // 
               // tabPage1
               // 
               this.tabPage1.Controls.Add(this.webBrowser1);
               this.tabPage1.Location = new System.Drawing.Point(4, 22);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(849, 402);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "tabPage1";
               this.tabPage1.UseVisualStyleBackColor = true;
               // 
               // tabControl1
               // 
               this.tabControl1.Controls.Add(this.tabPage1);
               this.tabControl1.Location = new System.Drawing.Point(13, 53);
               this.tabControl1.Name = "tabControl1";
               this.tabControl1.SelectedIndex = 0;
               this.tabControl1.Size = new System.Drawing.Size(857, 428);
               this.tabControl1.TabIndex = 2;
               // 
               // webBrowser1
               // 
               this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.webBrowser1.Location = new System.Drawing.Point(3, 3);
               this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
               this.webBrowser1.Name = "webBrowser1";
               this.webBrowser1.Size = new System.Drawing.Size(843, 396);
               this.webBrowser1.TabIndex = 0;
               // 
               // TigerNet
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(882, 493);
               this.Controls.Add(this.tabControl1);
               this.Controls.Add(this.toolStrip1);
               this.Controls.Add(this.menuStrip1);
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "TigerNet";
               this.Text = "TigerNet";
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.toolStrip1.ResumeLayout(false);
               this.toolStrip1.PerformLayout();
               this.tabPage1.ResumeLayout(false);
               this.tabControl1.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem savePageAsHTMLToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem exitWebBrowserToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
          private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
          private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.ToolStripButton BackButton;
          private System.Windows.Forms.ToolStripButton FowardButton;
          private System.Windows.Forms.ToolStripButton RefreshButton;
          private System.Windows.Forms.ToolStripButton HomeButton;
          private System.Windows.Forms.ToolStripTextBox AddressTextBox;
          private System.Windows.Forms.ToolStripButton GoButton;
          private System.Windows.Forms.ToolStripButton Bookmark;
          private System.Windows.Forms.TabPage tabPage1;
          private System.Windows.Forms.WebBrowser webBrowser1;
          private System.Windows.Forms.TabControl tabControl1;
     }
}