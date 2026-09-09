namespace CompanyContacts.DAL.Comparers;
public class CompanyLastContactedComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        if (ReferenceEquals(first, second)) { return 0; }
        if (first is null) { return -1; }
        if (second is null) { return 1; }
        return first.LastContacted.CompareTo(second.LastContacted);
    }
}