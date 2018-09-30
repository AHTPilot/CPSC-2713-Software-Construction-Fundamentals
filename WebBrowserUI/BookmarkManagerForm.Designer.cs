namespace WebBrowserUI
{
     partial class BookmarkHistoryForm
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
               this.listBoxBookmark = new System.Windows.Forms.ListBox();
               this.buttonClearBookmark = new System.Windows.Forms.Button();
               this.buttonDeleteBookmark = new System.Windows.Forms.Button();
               this.buttonSearchBookmark = new System.Windows.Forms.Button();
               this.textBoxSearchBookmark = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // listBoxBookmark
               // 
               this.listBoxBookmark.Dock = System.Windows.Forms.DockStyle.Fill;
               this.listBoxBookmark.FormattingEnabled = true;
               this.listBoxBookmark.Location = new System.Drawing.Point(0, 0);
               this.listBoxBookmark.Name = "listBoxBookmark";
               this.listBoxBookmark.Size = new System.Drawing.Size(538, 381);
               this.listBoxBookmark.TabIndex = 0;
               // 
               // buttonClearBookmark
               // 
               this.buttonClearBookmark.Location = new System.Drawing.Point(367, 345);
               this.buttonClearBookmark.Name = "buttonClearBookmark";
               this.buttonClearBookmark.Size = new System.Drawing.Size(75, 23);
               this.buttonClearBookmark.TabIndex = 8;
               this.buttonClearBookmark.Text = "Clear History";
               this.buttonClearBookmark.UseVisualStyleBackColor = true;
               this.buttonClearBookmark.Click += new System.EventHandler(this.buttonClearBookmark_Click);
               // 
               // buttonDeleteBookmark
               // 
               this.buttonDeleteBookmark.Location = new System.Drawing.Point(285, 345);
               this.buttonDeleteBookmark.Name = "buttonDeleteBookmark";
               this.buttonDeleteBookmark.Size = new System.Drawing.Size(75, 23);
               this.buttonDeleteBookmark.TabIndex = 7;
               this.buttonDeleteBookmark.Text = "Delete";
               this.buttonDeleteBookmark.UseVisualStyleBackColor = true;
               this.buttonDeleteBookmark.Click += new System.EventHandler(this.buttonDeleteBookmark_Click);
               // 
               // buttonSearchBookmark
               // 
               this.buttonSearchBookmark.Location = new System.Drawing.Point(204, 345);
               this.buttonSearchBookmark.Name = "buttonSearchBookmark";
               this.buttonSearchBookmark.Size = new System.Drawing.Size(75, 23);
               this.buttonSearchBookmark.TabIndex = 6;
               this.buttonSearchBookmark.Text = "Search";
               this.buttonSearchBookmark.UseVisualStyleBackColor = true;
               this.buttonSearchBookmark.Click += new System.EventHandler(this.buttonSearchBookmark_Click);
               // 
               // textBoxSearchBookmark
               // 
               this.textBoxSearchBookmark.Location = new System.Drawing.Point(12, 349);
               this.textBoxSearchBookmark.Name = "textBoxSearchBookmark";
               this.textBoxSearchBookmark.Size = new System.Drawing.Size(185, 20);
               this.textBoxSearchBookmark.TabIndex = 5;
               // 
               // BookmarkHistoryForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(538, 381);
               this.Controls.Add(this.buttonClearBookmark);
               this.Controls.Add(this.buttonDeleteBookmark);
               this.Controls.Add(this.buttonSearchBookmark);
               this.Controls.Add(this.textBoxSearchBookmark);
               this.Controls.Add(this.listBoxBookmark);
               this.Name = "BookmarkHistoryForm";
               this.Text = "BookmarkHistoryForm";
               this.Load += new System.EventHandler(this.BookmarkHistoryForm_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          public System.Windows.Forms.ListBox listBoxBookmark;
          private System.Windows.Forms.Button buttonClearBookmark;
          private System.Windows.Forms.Button buttonDeleteBookmark;
          private System.Windows.Forms.Button buttonSearchBookmark;
          private System.Windows.Forms.TextBox textBoxSearchBookmark;
     }
}