using CompanyContacts.DAL;

namespace CompanyContacts.DAO;

public class CompanyDao
{
    public IEnumerable<Company> GetCompanies()
    {
        return new List<Company>
        {
            new Company("Nordic Solutions", 12500000, 85)
            {
                Id = 6,
                LastContacted = new DateTime(2026, 8, 15),
                IsCustomer = true
            },
            new Company("BluePeak Technologies", 4870000, 32)
            {
                Id = 2,
                LastContacted = new DateTime(2026, 7, 22),
                IsCustomer = false
            },
            new Company("Greenfield Logistics", 23100000, 145)
            {
                Id = 8,
                LastContacted = new DateTime(2026, 8, 3),
                IsCustomer = true
            },
            new Company("Silverline Consulting", 3150000, 18)
            {
                Id = 5,
                LastContacted = new DateTime(2026, 6, 11),
                IsCustomer = false
            },
            new Company("OakTree Industries", 67200000, 420)
            {
                Id = 4,
                LastContacted = new DateTime(2026, 8, 27),
                IsCustomer = true
            },
            new Company("Sunrise Media", 8900000, 57)
            {
                Id = 12,
                LastContacted = new DateTime(2026, 5, 19),
                IsCustomer = false
            },
            new Company("Arctic Systems", 15400000, 73)
            {
                Id = 10,
                LastContacted = new DateTime(2026, 8, 30),
                IsCustomer = true
            },
            new Company("RedBridge Finance", 42300000, 210)
            {
                Id = 3,
                LastContacted = new DateTime(2026, 7, 8),
                IsCustomer = true
            },
            new Company("BrightPath Education", 5400000, 41)
            {
                Id = 9,
                LastContacted = new DateTime(2026, 4, 25),
                IsCustomer = false
            },
            new Company("WestCo Manufacturing", 98700000, 680)
            {
                Id = 7,
                LastContacted = new DateTime(2026, 8, 9),
                IsCustomer = true
            },
            new Company("CloudNine Software", 11800000, 64)
            {
                Id = 11,
                LastContacted = new DateTime(2026, 6, 29),
                IsCustomer = false
            },
            new Company("HarborPoint Energy", 35400000, 275)
            {
                Id = 1,
                LastContacted = new DateTime(2026, 7, 31),
                IsCustomer = true
            }
        };
    }
}
