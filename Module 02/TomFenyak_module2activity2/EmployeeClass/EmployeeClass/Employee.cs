using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
     class Employee
     {
          public string employeeName;
          public int employeeIdNumber;
          public string employeeDepartment;
          public string employeePosition;

          // constructor that creates an employee object and takes, name, id, dept, and pos as parameters
          public Employee(string name, int id, string dept, string pos)
          {
               employeeName = name;
               employeeIdNumber = id;
               employeeDepartment = dept;
               employeePosition = pos;
          }

          // constructor that creates an employee object and takes name and id as parameters
          public Employee(string name, int id)
          {
               employeeName = name;
               employeeIdNumber = id;
               employeeDepartment = "";
               employeePosition = "";
          }

          // constructor that creates an employee object and takes no parameters
          public Employee()
          {
               employeeName = "";
               employeeIdNumber = 0;
               employeeDepartment = "";
               employeePosition = "";
          }

     }
}
