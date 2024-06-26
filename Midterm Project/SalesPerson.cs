using System;

class SalesPerson : Employee
{
    enum SalesLevel
    {
        Platinum,
        Diamond,
        Gold, 
        Silver,
        Bronze
    }

    public string department;
    public float sales;
    public SalesLevel salesLevel;

    public void SalesPerson(string firstName, string lastName, string id, string department, float sales)
    {
        base.Employee(firstName, lastName, id, "Sales");
        this.department = department;
        this.sales = sales;
    }

    public void updateSales(float number)
    {
        this.sales += number;
    }

    public void getSalesLevel()
    {
        if (this.sales < 10000)
        {
            this.salesLevel = "Bronze";
        }
        else if (this.sales >= 10000 && this.sales <= 19999.99)
        {
            this.salesLevel = "Silver";
        }
        else if (this.sales >= 20000 && this.sales <= 29999.99)
        {
            this.salesLevel = "Gold";
        }
        else if (this.sales >= 30000 && this.sales <= 39999.99)
        {
            this.salesLevel = "Diamond";
        }
        else if (this.sales >= 40000)
        {
            this.salesLevel = "Platinum";
        }
    }
}