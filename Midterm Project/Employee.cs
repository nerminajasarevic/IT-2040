using System;
  
class Employee {
   
   enum EmployeeType
   {
        Sales,
        Manager,
        Production
   }

    public string firstName;
    public string lastName;
    public string id;
    public EmployeeType empType;

    public void Employee(string firstName, string lastName, string id, EmployeeType empType)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.empType = empType;
    }

    public void getEmployeeInfo()
    {
        Console.WriteLine($"Name: {firstName} {lastName}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Type: {empType}");
    }

    public string getFirstName()
    {
        return this.firstName;
    }

    public string setFirstName(string name)
    {
        this.firstName = name;
    }

    public string getLastName()
    {
        return this.lastName;
    }

    public string setLastName(string name)
    {
        this.lastName = name;
    }

    public EmployeeType getType()
    {
        return this.empType;
    }

    public EmployeeType setType(string type)
    {
        this.empType = type;
    }

    public string getID()
    {
        return this.id;
    }
}
  