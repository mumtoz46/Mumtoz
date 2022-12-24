using Domain.Models;
public class DepartmentService
{
    public List<Department> departments;
    public List<Department> GetDepartments ()
    {
return departments;
    }
    public DepartmentService()
    {
        departments = new List<Department>();
    }
    public void AddDepartments (Department department)
    {
        departments.Add(department);
    }
     public void UpdateDepartments (Department department)
    {
        var find  = departments.FirstOrDefault(x=>x.id == student.id);
        find.Description =department.Description;
        find.Name =department.Name;
        find.Id =department.Id;
    }
    public void Delete (int id)
    {
       var find  = departments.FirstOrDefault(x=>x.id == id); 
       departments.Remove(find);
    }
    public void Count ()
    {
        return departments.Count;
    }
}