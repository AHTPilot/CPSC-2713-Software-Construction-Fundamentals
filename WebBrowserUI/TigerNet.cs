using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WebBrowserUI
{
     public partial class TigerNet : Form
     {
          public TigerNet()
          {
               InitializeComponent();
          }

         

          private void webNavigationControl1_Load(object sender, EventArgs e)
          {

          }

          private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
          {
               MessageBox.Show("TigerNet is a Web Browswer created by Tom Fenyak (tjf0027@tigermail.auburn.edu) " +
                    "of the Auburn University Online Computer Science program. This is the Course Project for the " +
                    "CPSC 2713 Software Construction Fundamentals course. This project is Tom's first exposure to C# " +
                    "as a language. Enjoy and War Eagle!");
          }

          private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
          {

               TabPage myTabPage = new TabPage("New Tab");
               tabControl1.TabPages.Add(myTabPage);

               UserControl Web = new WebNavigationControl();
               Web.Dock = DockStyle.Fill;
               myTabPage.Controls.Add(Web);
          }

          private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
          {
               tabControl1.TabPages.Remove(tabControl1.SelectedTab);
          }

          private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var itemsForm = new BookmarkHistoryForm();
               itemsForm.ShowDialog();
          }

          private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var itemsForm = new HistoryManagerForm();
               itemsForm.ShowDialog();
          }

          private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
          {

          }
     }
}
