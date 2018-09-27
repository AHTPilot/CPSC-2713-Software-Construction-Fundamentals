namespace FileSearch
{
     partial class SearchForm
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
               this.buttonBrowse = new System.Windows.Forms.Button();
               this.buttonSearch = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.listBoxResult = new System.Windows.Forms.ListBox();
               this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
               this.SuspendLayout();
               // 
               // buttonBrowse
               // 
               this.buttonBrowse.Location = new System.Drawing.Point(219, 77);
               this.buttonBrowse.Name = "buttonBrowse";
               this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
               this.buttonBrowse.TabIndex = 0;
               this.buttonBrowse.Text = "Browse";
               this.buttonBrowse.UseVisualStyleBackColor = true;
               this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
               // 
               // buttonSearch
               // 
               this.buttonSearch.Location = new System.Drawing.Point(338, 77);
               this.buttonSearch.Name = "buttonSearch";
               this.buttonSearch.Size = new System.Drawing.Size(75, 23);
               this.buttonSearch.TabIndex = 1;
               this.buttonSearch.Text = "Search";
               this.buttonSearch.UseVisualStyleBackColor = true;
               this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(26, 39);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(148, 20);
               this.label1.TabIndex = 2;
               this.label1.Text = "Enter Word/Phrase:";
               // 
               // textBox1
               // 
               this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox1.Location = new System.Drawing.Point(180, 36);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(286, 26);
               this.textBox1.TabIndex = 3;
               // 
               // listBoxResult
               // 
               this.listBoxResult.FormattingEnabled = true;
               this.listBoxResult.Location = new System.Drawing.Point(30, 135);
               this.listBoxResult.Name = "listBoxResult";
               this.listBoxResult.Size = new System.Drawing.Size(436, 264);
               this.listBoxResult.TabIndex = 4;
               // 
               // openFileDialog1
               // 
               this.openFileDialog1.FileName = "openFileDialog1";
               // 
               // SearchForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(546, 453);
               this.Controls.Add(this.listBoxResult);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.buttonSearch);
               this.Controls.Add(this.buttonBrowse);
               this.Name = "SearchForm";
               this.Text = "File Search";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button buttonBrowse;
          private System.Windows.Forms.Button buttonSearch;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.ListBox listBoxResult;
          private System.Windows.Forms.OpenFileDialog openFileDialog1;
     }
}

