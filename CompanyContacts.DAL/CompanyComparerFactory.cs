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
                return null;
            case FactoryComparer.EmployeeCount:
                return null;
            case FactoryComparer.Revenue:
                return null;
            case FactoryComparer.LastContacted:
                return null;
            case FactoryComparer.IsCustomer:
                return null;
            default:
                return null;
        }
    }
}