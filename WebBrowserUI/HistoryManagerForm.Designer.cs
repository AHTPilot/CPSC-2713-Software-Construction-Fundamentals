namespace WebBrowserUI
{
     partial class HistoryManagerForm
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
               this.listBoxHistory = new System.Windows.Forms.ListBox();
               this.textBoxSearchHistory = new System.Windows.Forms.TextBox();
               this.buttonSearchHistory = new System.Windows.Forms.Button();
               this.buttonDeleteHistory = new System.Windows.Forms.Button();
               this.buttonClearHistory = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // listBoxHistory
               // 
               this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
               this.listBoxHistory.FormattingEnabled = true;
               this.listBoxHistory.Location = new System.Drawing.Point(0, 0);
               this.listBoxHistory.Name = "listBoxHistory";
               this.listBoxHistory.Size = new System.Drawing.Size(800, 450);
               this.listBoxHistory.TabIndex = 0;
               // 
               // textBoxSearchHistory
               // 
               this.textBoxSearchHistory.Location = new System.Drawing.Point(12, 430);
               this.textBoxSearchHistory.Name = "textBoxSearchHistory";
               this.textBoxSearchHistory.Size = new System.Drawing.Size(185, 20);
               this.textBoxSearchHistory.TabIndex = 1;
               // 
               // buttonSearchHistory
               // 
               this.buttonSearchHistory.Location = new System.Drawing.Point(204, 426);
               this.buttonSearchHistory.Name = "buttonSearchHistory";
               this.buttonSearchHistory.Size = new System.Drawing.Size(75, 23);
               this.buttonSearchHistory.TabIndex = 2;
               this.buttonSearchHistory.Text = "Search";
               this.buttonSearchHistory.UseVisualStyleBackColor = true;
               this.buttonSearchHistory.Click += new System.EventHandler(this.buttonSearchHistory_Click);
               // 
               // buttonDeleteHistory
               // 
               this.buttonDeleteHistory.Location = new System.Drawing.Point(285, 426);
               this.buttonDeleteHistory.Name = "buttonDeleteHistory";
               this.buttonDeleteHistory.Size = new System.Drawing.Size(75, 23);
               this.buttonDeleteHistory.TabIndex = 3;
               this.buttonDeleteHistory.Text = "Delete";
               this.buttonDeleteHistory.UseVisualStyleBackColor = true;
               this.buttonDeleteHistory.Click += new System.EventHandler(this.buttonDeleteHistory_Click);
               // 
               // buttonClearHistory
               // 
               this.buttonClearHistory.Location = new System.Drawing.Point(367, 426);
               this.buttonClearHistory.Name = "buttonClearHistory";
               this.buttonClearHistory.Size = new System.Drawing.Size(75, 23);
               this.buttonClearHistory.TabIndex = 4;
               this.buttonClearHistory.Text = "Clear History";
               this.buttonClearHistory.UseVisualStyleBackColor = true;
               this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
               // 
               // HistoryManagerForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.buttonClearHistory);
               this.Controls.Add(this.buttonDeleteHistory);
               this.Controls.Add(this.buttonSearchHistory);
               this.Controls.Add(this.textBoxSearchHistory);
               this.Controls.Add(this.listBoxHistory);
               this.Name = "HistoryManagerForm";
               this.Text = "HistoryManagerForm";
               this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox listBoxHistory;
          private System.Windows.Forms.TextBox textBoxSearchHistory;
          private System.Windows.Forms.Button buttonSearchHistory;
          private System.Windows.Forms.Button buttonDeleteHistory;
          private System.Windows.Forms.Button buttonClearHistory;
     }
}