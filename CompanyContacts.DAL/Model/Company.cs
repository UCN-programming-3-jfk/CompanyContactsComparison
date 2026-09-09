namespace CompanyContacts.DAL;

public class Company : IComparable<Company>
{
    #region Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public int YearlyRevenue { get; set; }
    public int EmployeeCount { get; set; }
    public DateTime LastContacted { get; set; }
    public bool IsCustomer { get; set; }

    #endregion

    public Company(string name, int yearlyRevenue, int employeeCount)
    {
        Name = name;
        YearlyRevenue = yearlyRevenue;
        EmployeeCount = employeeCount;
    }

    public override string ToString()
    {
        return $"({Id:000}){Name?.ToUpper()}";
    }

    public int CompareTo(Company? other)
    {
        return Name.CompareTo(other.Name);
    }
}