namespace CompanyContacts.DAL.Comparers;

internal class FactoryIdComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        return first.Id.CompareTo(second.Id);
    }
}