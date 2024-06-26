using System;

class Manager : Employee
{
    public string department;
    public string region;

    public void Manager(string firstName, string lastName, string id, string department, string region)
    {
        base.Employee(firstName, lastName, id, "Manager");
        this.department = department;
        this.region = region;
    }

    public string getDepartment()
    {
        return this.department;
    }

    public string setDepartment(string name)
    {
        this.department = name;
    }

    public string getRegion()
    {
        return this.region;
    }

    public string setRegion(string name)
    {
        this.region = name;
    }
}