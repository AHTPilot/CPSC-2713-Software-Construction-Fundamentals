using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowserUI
{
     public partial class BookmarkHistoryForm : Form
     {
          public BookmarkHistoryForm()
          {
               InitializeComponent();
          }

          private void BookmarkHistoryForm_Load(object sender, EventArgs e)
          {
               var items = BookmarkManager.GetBookmarkItems();
               listBoxBookmark.Items.Clear();

               foreach (var item in items)
               {
                    listBoxBookmark.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
               }
          }

          private void buttonSearchBookmark_Click(object sender, EventArgs e)
          {
               {
                    var items = HistoryManager.GetHistoryItems();

                    listBoxBookmark.Items.Clear();

                    foreach (var item in items)
                    {
                         if (item.Title.Contains(textBoxSearchBookmark.Text) || item.URL.Contains(textBoxSearchBookmark.Text))
                         {
                              listBoxBookmark.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                         }

                    }
               }
          }

          private void buttonClearBookmark_Click(object sender, EventArgs e)
          {
               BookmarkManager.ClearBookmark();
               listBoxBookmark.Items.Clear();
          }

          private void buttonDeleteBookmark_Click(object sender, EventArgs e)
          {

               string input = listBoxBookmark.GetItemText(listBoxBookmark.SelectedItem);

               HistoryManager.RemoveHistoryItem(input);
               listBoxBookmark.Items.RemoveAt(listBoxBookmark.SelectedIndex);

          }
     }
}
