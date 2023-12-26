using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInvPrinciple.solution
{
    public class EmployeeDataAccessLogicSol: IEmployeeDataAccessLogic
    {
        public EmployeeSol GetEmployeeDetails(int id)
        {
            //In real time get the employee details from database
            //but here we have hard coded the employee details
            EmployeeSol emp = new EmployeeSol()
            {
                ID = id,
                Name = "Ashu",
                Department = "CL",
                Salary = 9999
            };
            return emp;
        }
    }
}

