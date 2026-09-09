namespace CompanyContacts.DAL.Comparers;

internal class CompanyEmployeeCountComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        return first.EmployeeCount.CompareTo(second.EmployeeCount);
    }
}