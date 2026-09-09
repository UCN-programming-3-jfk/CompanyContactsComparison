namespace CompanyContacts.DAL.Comparers;

public class CompanyLastContactedComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        return first.LastContacted.CompareTo(second.LastContacted);
    }
}