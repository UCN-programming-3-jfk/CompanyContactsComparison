namespace CompanyContacts.DAL.Comparers;

internal class CompanyRevenueComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        return first.YearlyRevenue.CompareTo(second.YearlyRevenue);
    }
}