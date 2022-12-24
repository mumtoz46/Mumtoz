
var employeeService = new EmployeeService();
int counter = 1;
while (true)
{
    string option = Console.ReadLine();
    if (option == "stop") break;
    _ = option switch
    {
        "show" => Show(),
        "insert" => Insert(),
        "delete" => Delete(),
        "update" => Update(),
        _ => false,

    };
    bool Show()
    {
        var employees = employeeService.GemployeeService();
        System.Console.WriteLine($"Id        FirstName              LastName                ");
        foreach (var tch in employees)
        {
            System.Console.WriteLine($"{tch._Id}           {tch._FirstName}                   {tch._LastName}         ");
        }
        return true;
    }
    bool Insert()
    {
        var employees = new Employee(counter);
        System.Console.Write("Enter Your FirstName: ");
        employees._FirstName = Console.ReadLine();
        System.Console.Write("Enter Your LastName: ");
        employees._LastName = Console.ReadLine();
        // System.Console.Write("Enter Your Position: ");
        // employees.Position = Console.ReadLine();
        //  System.Console.Write("Enter Your ExperienceAmount: ");
        // employees.ExperienceAmount = Convert.ToInt32(Console.ReadLine());

        employeeService.AddEmployee(employees);
        counter++;
        return true;
    }
      bool Update ()
    {
        System.Console.Write("Employee Id: ");
        int _Id = Convert.ToInt32(Console.ReadLine());
        var employees = new Employee(_Id);
        System.Console.Write("Your UpDate FirstName: ");
        employees._FirstName = Console.ReadLine();
        System.Console.Write("Your UpDate LastName: ");
        employees._LastName = Console.ReadLine();
        //  System.Console.Write("Enter Your updated Position: ");
        // employees.Position = Console.ReadLine();
        //  System.Console.Write("Enter Your updated ExperienceAmount: ");
        // employees.ExperienceAmount = Convert.ToInt32(Console.ReadLine());
        employeeService.UppDate(employees);
        return true;
    }
    bool Delete()
    {
        System.Console.Write("Teacher Id: ");
        int _Id = Convert.ToInt32(Console.ReadLine());
        employeeService.Delete(_Id);
        return true;
    }
}