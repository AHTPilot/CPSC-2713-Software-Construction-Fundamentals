﻿using System;
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
     public partial class HistoryManagerForm : Form
     {
          string keyword;

          public HistoryManagerForm()
          {
               InitializeComponent();
          }

          private void HistoryManagerForm_Load(object sender, EventArgs e)
          {
               var items = HistoryManager.GetHistoryItems();
               listBoxHistory.Items.Clear();

               foreach(var item in items)
               {
                    listBoxHistory.Items.Add(string.Format("[{0}] {1} {2}", item.Date, item.Title, item.URL));
               }
          }

          private void buttonSearchHistory_Click(object sender, EventArgs e)
          {
               {
                    var items = HistoryManager.GetHistoryItems();

                    listBoxHistory.Items.Clear();

                    foreach (var item in items)
                    {
                         if (item.Title.Contains(textBoxSearchHistory.Text) || item.URL.Contains(textBoxSearchHistory.Text))
                         {
                              listBoxHistory.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                         }

                    }
               }
          }

          private void buttonClearHistory_Click(object sender, EventArgs e)
          {
               listBoxHistory.Items.Clear();
               
          }

          private void buttonDeleteHistory_Click(object sender, EventArgs e)
          {
               if (this.listBoxHistory.SelectedIndex >= 0)
                    this.listBoxHistory.Items.RemoveAt(this.listBoxHistory.SelectedIndex);
               
          }
     }
}
