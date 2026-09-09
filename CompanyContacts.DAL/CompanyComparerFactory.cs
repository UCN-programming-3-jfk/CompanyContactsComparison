using CompanyContacts.DAL.Comparers;

namespace CompanyContacts.DAL;

public static class CompanyComparerFactory
{
    public enum FactoryComparer { None, Id, Name, EmployeeCount, Revenue, LastContacted,IsCustomer }


    public static IComparer<Company> GetComparer(FactoryComparer comparerType)
    {
        switch (comparerType)
        {
            case FactoryComparer.Id:
                return new FactoryIdComparer();
            case FactoryComparer.Name:
                return new FactoryIdComparer();
            case FactoryComparer.EmployeeCount:
                return new FactoryIdComparer();
            case FactoryComparer.Revenue:
                return new FactoryIdComparer();
            case FactoryComparer.LastContacted:
                return new FactoryIdComparer();
            case FactoryComparer.IsCustomer:
                return new FactoryIdComparer();
            default:
                return null;
        }
    }
}