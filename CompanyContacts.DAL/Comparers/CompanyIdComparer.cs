namespace CompanyContacts.DAL.Comparers;

public class CompanyIdComparer : IComparer<Company>
{
    public int Compare(Company? x, Company? y)
    {
        if (ReferenceEquals(x, y)) { return 0; }
        if (x is null) { return -1; }
        if (y is null) { return 1; }
        return x.Id.CompareTo(y.Id);
    }
}
