using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          // have the output appear in textBox6 (right side of form) as the total visit cost test
          private void button1_Click(object sender, EventArgs e)
          {
               textBox6.Text = CalcTotalCharges().ToString();
          }

          // method to calculate the stay charges that are 350 dollars per day
          private int CalcStayCharges()
          {
               int daysStayed = int.Parse(textBox1.Text);
               // Calculate the stay charges which is $350/day
               int stayCharges = daysStayed * 350;

               return stayCharges;
          }
          
          // method to calculate misc charges associated with patient stay
          private int CalcMiscCharges()
          {
               int medCharges = int.Parse(textBox2.Text);
               int surgCharges = int.Parse(textBox3.Text);
               int labFees = int.Parse(textBox4.Text);
               int rehabCharges = int.Parse(textBox5.Text);
               // calculate misc charges including medication, surgical, lab, and rehab charges.
               int miscCharges = medCharges + surgCharges + labFees + rehabCharges;

               return miscCharges;
          }

          // method that calculates the total of charges associated with the patient stay
          private int CalcTotalCharges()
          {
               int totalCharges = CalcMiscCharges() + CalcStayCharges();
               return totalCharges;
          }

          // closes the program
          private void button2_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
