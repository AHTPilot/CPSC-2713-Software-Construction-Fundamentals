using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
          }

          private void AddressTextBox_KeyDown(object sender, KeyEventArgs e)
          {
               if (e.KeyCode == Keys.Enter)
               {
                    webBrowser1.Navigate(AddressTextBox.Text);
                    backLinks.Push(AddressTextBox.Text);
               }
          }

       

          private void RefreshButton_Click(object sender, EventArgs e)
          {
               webBrowser1.Navigate(AddressTextBox.Text);
          }

          private void BackButton_Click(object sender, EventArgs e)
          {
               forwardLinks.Push(AddressTextBox.Text);
               webBrowser1.Navigate(backLinks.Pop());
          }

          private void FowardButton_Click(object sender, EventArgs e)
          {
               backLinks.Push(AddressTextBox.Text);
               webBrowser1.Navigate(forwardLinks.Pop());
          }

          
     }
}
