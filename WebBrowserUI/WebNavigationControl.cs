using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using System.Text.RegularExpressions;

namespace WebBrowserUI
{
     public partial class WebNavigationControl : UserControl
     {
          Stack<string> backLinks = new Stack<string>();
          Stack<string> forwardLinks = new Stack<string>();

          public WebNavigationControl()
          {
               InitializeComponent();
          }


          private void GoButton_Click(object sender, EventArgs e)
          {
               webBrowser1.Navigate(AddressTextBox.Text);
               backLinks.Push(AddressTextBox.Text);
               timer1.Start();
               toolStripStatusLabel1.Text = "Loading";
               toolStripProgressBarLoading.Value = 0;
          }

          private void AddressTextBox_KeyDown(object sender, KeyEventArgs e)
          {
               if (e.KeyCode == Keys.Enter)
               {
                    webBrowser1.Navigate(AddressTextBox.Text);
                    backLinks.Push(AddressTextBox.Text);

                    timer1.Start();
                    toolStripStatusLabel1.Text = "Loading";
                    toolStripProgressBarLoading.Value = 0;
               }
          }

       

          private void RefreshButton_Click(object sender, EventArgs e)
          {
               webBrowser1.Navigate(AddressTextBox.Text);

               timer1.Start();
               toolStripStatusLabel1.Text = "Loading";
               toolStripProgressBarLoading.Value = 0;
          }

          private void BackButton_Click(object sender, EventArgs e)
          {
               forwardLinks.Push(AddressTextBox.Text);
               webBrowser1.Navigate(backLinks.Pop());
               timer1.Start();
               toolStripStatusLabel1.Text = "Loading";
               toolStripProgressBarLoading.Value = 0;
          }

          private void FowardButton_Click(object sender, EventArgs e)
          {
               backLinks.Push(AddressTextBox.Text);
               webBrowser1.Navigate(forwardLinks.Pop());

               timer1.Start();
               toolStripStatusLabel1.Text = "Loading";
               toolStripProgressBarLoading.Value = 0;
          }

          private void Bookmark_Click(object sender, EventArgs e)
          {
               var item = new BookmarkItem();
               item.URL = AddressTextBox.Text;
               item.Title = webBrowser1.DocumentTitle;

               BookmarkManager.addItemBookmark(item);

          }

          private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
          {
               if (webBrowser1.Url.AbsoluteUri == e.Url.AbsoluteUri)
               {

                    var item = new HistoryItem();
                    item.URL = AddressTextBox.Text;
                    item.Title = webBrowser1.DocumentTitle;
                    item.Date = DateTime.Now.ToString("mm/dd/yyyy HH:mm:ss");

                    HistoryManager.addItemHistory(item);
                    toolStripStatusLabel1.Text = "Done";
                    timer1.Stop();
                    toolStripProgressBarLoading.Value = 100;
               }
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
               if (this.toolStripProgressBarLoading.Value == 100)
               {
                    timer1.Stop();
                    toolStripStatusLabel1.Text = "Done";
               }
               else
               {
                    this.toolStripProgressBarLoading.Value++;
               }
          }
     }
}
