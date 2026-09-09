namespace CompanyContacts.DAL.Comparers;

public static class CompanyComparerFactory
{
    public enum CompanyComparer { None, Id, Name, EmployeeCount, Revenue, LastContacted,IsCustomer }


    public static IComparer<Company>? GetComparer(CompanyComparer comparerType)
    {
        switch (comparerType)
        {
            case CompanyComparer.Id:
                return new CompanyIdComparer();
            case CompanyComparer.EmployeeCount:
                return new CompanyEmployeeCountComparer();
            case CompanyComparer.Revenue:
                return new CompanyRevenueComparer();
            case CompanyComparer.LastContacted:
                return new CompanyLastContactedComparer();
            case CompanyComparer.IsCustomer:
                return new CompanyIsCustomerComparer();
            default:
                return null;
        }
    }
}