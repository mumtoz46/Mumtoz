using System.Collections.Generic;
using Domain.Models;
namespace Infrastructure.Services;
public class EmployeeService
{
    public List <Employee> employees;
    public List<Employee> GetEmployees()
    {
        return employees;
    }
    public EmployeeService()
    {
        employees = new List<Employee>();
    }
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    public void UpdateEmployee(Employee employee)
    {
        var find = employees.FirstOrDefault(x => x._Id == employee.id);
        find.Address = employee._Address;
        find.BirthDate = employee._BirthDate;
        find.FirstName = employee._FirstName;
    }
    public void Delete(int id)
    {
        var find = employees.FirstOrDefault(x => x._Id == id);
        employees.Remove(find);
    }
    public void Count()
    {
        return employees.Count;
    }
}