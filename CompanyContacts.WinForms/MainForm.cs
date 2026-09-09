using CompanyContacts.DAL;
using CompanyContacts.DAL.Comparers;
using CompanyContacts.DAO;

namespace CompanyContacts.WinForms;

public partial class MainForm : Form
{
    #region variables
    private List<Company> _companies;
    private IComparer<Company> _comparer; 
    #endregion

    #region Constructor and setup
    public MainForm()
    {
        InitializeComponent();
        CreateColumnsOnListBox();
    }

    private void CreateColumnsOnListBox()
    {
        lstCompanies.Columns.Add("Id", 50);
        lstCompanies.Columns.Add("Name", 200);
        lstCompanies.Columns.Add("Employees", 200);
        lstCompanies.Columns.Add("Revenue", 250);
        lstCompanies.Columns.Add("Last contacted", 300);
        lstCompanies.Columns.Add("Customer", 150);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        LoadCompanies();
        ShowCompanies();
    }

    private void LoadCompanies()
    {
        _companies = new CompanyDao().GetCompanies().ToList();
    }
    #endregion

    #region Sort and show
    private void SortCompanies()
    {
        if (_comparer != null) { _companies.Sort(_comparer); }
        else { _companies.Sort(); }
    }

    private void ShowCompanies()
    {
        lstCompanies.Items.Clear(); //remove existing companies

        //add rows with fields that match the columns
        foreach (Company company in _companies)
        {
            var item = new ListViewItem(company.Id.ToString("00"));
            item.SubItems.Add(company.Name);
            item.SubItems.Add(company.EmployeeCount.ToString("N0"));
            item.SubItems.Add(company.YearlyRevenue.ToString("C0"));
            item.SubItems.Add(company.LastContacted.ToString("yyyy-MM-dd"));
            item.SubItems.Add(company.IsCustomer ? "Yes" : "No");

            if (company.IsCustomer) //customers have a green background
            {
                item.BackColor = Color.LightGreen;
            }

            lstCompanies.Items.Add(item);
        }
        //ensure a column width, which matches the header width
        lstCompanies.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    } 
    #endregion

    #region Eventhandling
    private void btnSortByName_Click(object sender, EventArgs e)
    {
        SortByNameAndShow();
    }

    private void btnId_Click(object sender, EventArgs e)
    {
        SortByIdAndShow();
    }

    private void btnEmployeeCount_Click(object sender, EventArgs e)
    {
        SortByEmployeeCountAndShow();
    }

    private void btnYearlyRevenue_Click(object sender, EventArgs e)
    {
        SortByYearlyRevenueAndShow();
    }

    private void btnLastContacted_Click(object sender, EventArgs e)
    {
        SortByLastContactedAndShow();
    }

    private void btnIsCustomer_Click(object sender, EventArgs e)
    {
        SortByIsCustomerAndShow();
    }
    #endregion

    #region IComparer retrieval methods
    private void SortByNameAndShow()
    {
        _comparer = null;   //remove comparer, so companies are sorted by IComparable (Name)
        SortCompanies();
        ShowCompanies();
    }

    private void SortByIdAndShow()
    {
        //get a comparer which uses companies' Id for comparison
        _comparer = CompanyComparerFactory.GetComparer(CompanyComparerFactory.CompanyComparer.Id);
        SortCompanies();
        ShowCompanies();
    }

    private void SortByLastContactedAndShow()
    {
        //get a comparer which uses companies' last contacted date 
        // for comparison
        _comparer = CompanyComparerFactory.GetComparer(CompanyComparerFactory.CompanyComparer.LastContacted);
        SortCompanies();
        ShowCompanies();
    }

    private void SortByYearlyRevenueAndShow()
    {
        //get a comparer which uses companies' revenue for comparison
        _comparer = CompanyComparerFactory.GetComparer(CompanyComparerFactory.CompanyComparer.Revenue);
        SortCompanies();
        ShowCompanies();
    }

    private void SortByEmployeeCountAndShow()
    {
        //get a comparer which uses companies' employeecount
        // for comparison
        _comparer = CompanyComparerFactory.GetComparer(CompanyComparerFactory.CompanyComparer.EmployeeCount);
        SortCompanies();
        ShowCompanies();
    }


    private void SortByIsCustomerAndShow()
    {
        //get a comparer which uses companies' is customer property
        // for comparison
        _comparer = CompanyComparerFactory.GetComparer(CompanyComparerFactory.CompanyComparer.IsCustomer);
        SortCompanies();
        ShowCompanies();
    } 
    #endregion

}