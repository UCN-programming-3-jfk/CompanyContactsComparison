namespace CompanyContacts.DAL.Comparers;

internal class CompanyIdComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        return first.Id.CompareTo(second.Id);
    }
}