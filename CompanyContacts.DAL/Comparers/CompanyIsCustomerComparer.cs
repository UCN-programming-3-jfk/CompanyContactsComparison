namespace CompanyContacts.DAL.Comparers;

public class CompanyIsCustomerComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        if (ReferenceEquals(first, second)) { return 0;}
        if (first is null) { return -1; }
        if (second is null) { return 1; }
        return first.IsCustomer.CompareTo(second.IsCustomer);
    }
}