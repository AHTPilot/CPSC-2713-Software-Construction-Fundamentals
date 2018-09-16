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
               this.tabControl1 = new System.Windows.Forms.TabControl();
               this.webBrowser1 = new System.Windows.Forms.WebBrowser();
               this.webNavigationControl1 = new WebBrowserUI.WebNavigationControl();
               this.tabPage1.SuspendLayout();
               this.tabControl1.SuspendLayout();
               this.SuspendLayout();
               // 
               // tabPage1
               // 
               this.tabPage1.Controls.Add(this.webNavigationControl1);
               this.tabPage1.Controls.Add(this.webBrowser1);
               this.tabPage1.Location = new System.Drawing.Point(4, 22);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(942, 451);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "tabPage1";
               this.tabPage1.UseVisualStyleBackColor = true;
               // 
               // tabControl1
               // 
               this.tabControl1.Controls.Add(this.tabPage1);
               this.tabControl1.Location = new System.Drawing.Point(3, 4);
               this.tabControl1.Name = "tabControl1";
               this.tabControl1.SelectedIndex = 0;
               this.tabControl1.Size = new System.Drawing.Size(950, 477);
               this.tabControl1.TabIndex = 2;
               // 
               // webBrowser1
               // 
               this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.webBrowser1.Location = new System.Drawing.Point(3, 3);
               this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
               this.webBrowser1.Name = "webBrowser1";
               this.webBrowser1.Size = new System.Drawing.Size(936, 445);
               this.webBrowser1.TabIndex = 0;
               // 
               // webNavigationControl1
               // 
               this.webNavigationControl1.Location = new System.Drawing.Point(0, 0);
               this.webNavigationControl1.Name = "webNavigationControl1";
               this.webNavigationControl1.Size = new System.Drawing.Size(919, 445);
               this.webNavigationControl1.TabIndex = 1;
               this.webNavigationControl1.Load += new System.EventHandler(this.webNavigationControl1_Load);
               // 
               // TigerNet
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(965, 493);
               this.Controls.Add(this.tabControl1);
               this.Name = "TigerNet";
               this.Text = "TigerNet";
               this.tabPage1.ResumeLayout(false);
               this.tabControl1.ResumeLayout(false);
               this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.TabPage tabPage1;
          private System.Windows.Forms.TabControl tabControl1;
          private System.Windows.Forms.WebBrowser webBrowser1;
          private WebNavigationControl webNavigationControl1;
     }
}