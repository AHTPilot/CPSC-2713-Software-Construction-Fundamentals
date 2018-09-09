﻿using System;
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

          private void AddressTextBox_Click(object sender, EventArgs e)
          {
               webBrowser1.Navigate(AddressTextBox.Text);
          }

          private void GoButton_Click(object sender, EventArgs e)
          {
               webBrowser1.Navigate(AddressTextBox.Text);
          }
     }
}
