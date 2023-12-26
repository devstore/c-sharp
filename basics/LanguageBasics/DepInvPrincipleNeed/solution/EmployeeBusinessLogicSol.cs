using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInvPrinciple.solution
{
    public class EmployeeBusinessLogicSol
    {
        IEmployeeDataAccessLogic _IEmployeeDataAccessLogic;
        public EmployeeBusinessLogicSol()
        {
            _IEmployeeDataAccessLogic = DataAccessFactorySol.GetEmployeeDataAccessObj();
        }
        public EmployeeSol GetEmployeeDetails(int id)
        {
            return _IEmployeeDataAccessLogic.GetEmployeeDetails(id);
        }
    }
}
