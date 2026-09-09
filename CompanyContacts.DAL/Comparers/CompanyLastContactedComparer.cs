namespace CompanyContacts.DAL.Comparers;

internal class CompanyLastContactedComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        return first.LastContacted.CompareTo(second.LastContacted);
    }
}