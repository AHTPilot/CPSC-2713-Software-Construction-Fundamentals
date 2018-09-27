using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileSearch
{
     public partial class SearchForm : Form
     {
          StreamReader inputFile;
          string keyword;
          string input;
          string result;
          

          public SearchForm()
          {
               InitializeComponent();
          }

          private void buttonBrowse_Click(object sender, EventArgs e)
          {
               openFileDialog1.ShowDialog();

               if (openFileDialog1.ShowDialog() == DialogResult.OK)
               {
                    inputFile = File.OpenText(openFileDialog1.FileName);
               }

               else 
               {
                    MessageBox.Show("Operation cancelled!");
               }
          }

          private void buttonSearch_Click(object sender, EventArgs e)
          {
               keyword = textBox1.Text;
               inputFile = File.OpenText(openFileDialog1.FileName);

               while (!inputFile.EndOfStream)
               {
                    input = inputFile.ReadLine();
                    if (input.Contains(keyword))
                    {
                         listBoxResult.Items.Add(input);
                    }
               }

               inputFile.Close();
          }
     }
}
