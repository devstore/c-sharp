using DepInvPrinciple.problem;
using DepInvPrinciple.solution;
using System;
namespace DepInvPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {

            /* Dependency Inversion Principle
             * https://dotnettutorials.net/lesson/dependency-inversion-principle/
             */

            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
            Console.ReadKey();

            EmployeeBusinessLogicSol s= new EmployeeBusinessLogicSol();
            EmployeeSol emp2 = s.GetEmployeeDetails(1002);
            Console.WriteLine($"ID: {emp2.ID}, Name: {emp2.Name}, Department: {emp2.Department}, Salary: {emp2.Salary}");
            Console.ReadKey();


        }
    }
}