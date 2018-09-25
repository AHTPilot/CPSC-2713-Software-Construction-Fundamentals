using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClass
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          // when user clicks "Show Employee" button, each employee will be shown in a message box in order.
          private void button1_Click(object sender, EventArgs e)
          {
               // creates first employee using the constructor that accepts name, id, dept, and pos as parameters
               Employee employee = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
               MessageBox.Show("Name: " + employee.employeeName + "\nID: " + employee.employeeIdNumber.ToString() + "\nDepartment: " + employee.employeeDepartment + "\nPosition: " + employee.employeePosition);

               // creates second employee using constructor that accepts name and id as parameters
               Employee employee2 = new Employee("Mark Jones", 39119);
               employee2.employeeDepartment = "IT";
               employee2.employeePosition = "Programmer";
               MessageBox.Show("Name: " + employee2.employeeName + "\nID: " + employee2.employeeIdNumber.ToString() + "\nDepartment: " + employee2.employeeDepartment + "\nPosition: " + employee2.employeePosition);

               // creates third employee using constructor that accepts no parameters
               Employee employee3 = new Employee();
               employee3.employeeName = "Joy Rogers";
               employee3.employeeIdNumber = 81774;
               employee3.employeeDepartment = "Manufacturing";
               employee3.employeePosition = "Engineer";
               MessageBox.Show("Name: " + employee3.employeeName + "\nID: " + employee3.employeeIdNumber.ToString() + "\nDepartment: " + employee3.employeeDepartment + "\nPosition: " + employee3.employeePosition);
          }

          private void button2_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
