namespace CompanyContacts.DAL.Comparers;
public class CompanyRevenueComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        if (ReferenceEquals(first, second)) { return 0; }
        if (first is null) { return -1; }
        if (second is null) { return 1; }
        return first.YearlyRevenue.CompareTo(second.YearlyRevenue);
    }
}