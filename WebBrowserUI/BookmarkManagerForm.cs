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
               listBox1.Items.Clear();

               foreach (var item in items)
               {
                    listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
               }
          }
     }
}
