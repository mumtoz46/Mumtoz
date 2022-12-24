using Domain.Models;
public class RoleService
{
    public List<Role> roles;
    public List<Role> GetRoles()
    {
        return roles;
    }
    public RoleService()
    {
        roles = new List<Role>();
    }
    public void AddRole(Role employee)
    {
        roles.Add(employee);
    }
    public void UpdateRole(Role role, int id)
    {
        var find = employees.FirstOrDefault(x => x._Id == employee.id);
        find.Id = role.Id;
        find.Name = role.Name;
        find.Description = role.Description;
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