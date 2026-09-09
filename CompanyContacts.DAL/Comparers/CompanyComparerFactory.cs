using CompanyContacts.DAL.Comparers;

namespace CompanyContacts.DAL;

public static class CompanyComparerFactory
{
    public enum CompanyComparerType { None, Id, Name, EmployeeCount, Revenue, LastContacted,IsCustomer }


    public static IComparer<Company> GetComparer(CompanyComparerType comparerType)
    {
        switch (comparerType)
        {
            case CompanyComparerType.Id:
                return new CompanyIdComparer();
            case CompanyComparerType.Name:
                return null;
            case CompanyComparerType.EmployeeCount:
                return null;
            case CompanyComparerType.Revenue:
                return null;
            case CompanyComparerType.LastContacted:
                return null;
            case CompanyComparerType.IsCustomer:
                return null;
            default:
                return null;
        }
    }
}