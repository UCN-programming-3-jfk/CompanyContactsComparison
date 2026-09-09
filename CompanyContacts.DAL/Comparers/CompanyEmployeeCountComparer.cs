namespace CompanyContacts.DAL.Comparers;

public class CompanyEmployeeCountComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        return first.EmployeeCount.CompareTo(second.EmployeeCount);
    }
}