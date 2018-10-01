using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
     public class BookmarkManager
     {
          public static void addItemBookmark(BookmarkItem item)
          {
               var adapter = new BookmarksTableAdapter();
               adapter.Insert(item.URL, item.Title);
          }

          public static List<BookmarkItem> GetBookmarkItems()
          {
               var adapter = new BookmarksTableAdapter();
               var results = new List<BookmarkItem>();
               var rows = adapter.GetData();

               foreach(var row in rows)
               {
                    var item = new BookmarkItem();
                    item.URL = row.URL;
                    item.Title = row.Title;
                    item.Id = row.Id;

                    results.Add(item);
               }

               return results;     
          }

          public static void ClearBookmark()
          {
               var adapter = new BookmarksTableAdapter();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    adapter.Delete(row.Id, row.URL, row.Title);
               }
          }

          public static void RemoveBookmarkItem(string bookmarkToRemove)
          {
               var adapter = new BookmarksTableAdapter();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    string check = string.Format("[{0}] {1} {2}",row.Id, row.Title, row.URL);

                    if (check == bookmarkToRemove)
                    {
                         adapter.Delete(row.Id, row.URL, row.Title);
                    }

               }
          }
     }
}
