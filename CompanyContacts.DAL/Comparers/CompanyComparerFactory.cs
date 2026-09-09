namespace CompanyContacts.DAL.Comparers;

public static class CompanyComparerFactory
{
    public enum CompanyComparerType { None, Id, Name, EmployeeCount, Revenue, LastContacted,IsCustomer }


    public static IComparer<Company>? GetComparer(CompanyComparerType comparerType)
    {
        switch (comparerType)
        {
            case CompanyComparerType.Id:
                return new CompanyIdComparer();
            case CompanyComparerType.EmployeeCount:
                return new CompanyEmployeeCountComparer();
            case CompanyComparerType.Revenue:
                return new CompanyRevenueComparer();
            case CompanyComparerType.LastContacted:
                return new CompanyLastContactedComparer();
            case CompanyComparerType.IsCustomer:
                return new CompanyIsCustomerComparer();
            default:
                return null;
        }
    }
}