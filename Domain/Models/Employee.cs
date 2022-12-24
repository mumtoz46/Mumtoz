public class Employee
{
 
    public int _Id { get; set; }
    public string _FirstName { get; set; }
    public string _LastName { get; set; }
    public DateTime _BirthDate { get; set; }
    public string _Address { get; set; }
    public string _Phone { get; set; }
    public Department _Department { get; set; }
    public List<Role> _Roles { get; set; }
    public List<Experience> _Experiences { get; set; }
    public int GetId()
 {
    return _Id;
 }
 public string  GetFirstName()
 {
    return _FirstName;
 }
 public string GetLastName()
 {
    return _LastName;
 }
 public DateTime GetDateTime ()
 {
    return _BirthDate;
 }
 public string Address()
 {
    return _Address;
 }
 public string Phone()
 {
    return _Phone;
 }

}
