namespace CompanyContacts.DAL.Comparers;

public class CompanyRevenueComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        return first.YearlyRevenue.CompareTo(second.YearlyRevenue);
    }
}