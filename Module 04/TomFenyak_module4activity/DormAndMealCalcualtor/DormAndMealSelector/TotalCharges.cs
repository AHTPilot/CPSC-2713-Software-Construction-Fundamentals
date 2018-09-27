using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealSelector
{
     public partial class TotalCharges : Form
     {
          public TotalCharges()
          {
               InitializeComponent();
          }


          public void btnCalc_Click(object sender, EventArgs e)
          {
               DialogResult = System.Windows.Forms.DialogResult.OK;
               Close();
          }

     }
}