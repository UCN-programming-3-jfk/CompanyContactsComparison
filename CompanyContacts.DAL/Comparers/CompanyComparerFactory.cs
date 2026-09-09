namespace CompanyContacts.DAL.Comparers;

public static class CompanyComparerFactory
{
    public enum FactoryComparer { None, Id, Name, EmployeeCount, Revenue, LastContacted,IsCustomer }


    public static IComparer<Company> GetComparer(FactoryComparer comparerType)
    {
        switch (comparerType)
        {
            case FactoryComparer.Id:
                return new CompanyIdComparer();
            case FactoryComparer.EmployeeCount:
                return new CompanyEmployeeCountComparer();
            case FactoryComparer.Revenue:
                return new CompanyRevenueComparer();
            case FactoryComparer.LastContacted:
                return new CompanyLastContactedComparer();
            case FactoryComparer.IsCustomer:
                return new CompanyIsCustomerComparer();
            default:
                return null;
        }
    }
}