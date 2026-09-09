namespace CompanyContacts.DAL.Comparers;

internal class CompanyIsCustomerComparer : IComparer<Company>
{
    public int Compare(Company? first, Company? second)
    {
        return first.IsCustomer.CompareTo(second.IsCustomer);
    }
}