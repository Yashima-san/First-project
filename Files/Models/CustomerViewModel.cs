public class CustomerViewModel
{
    private readonly DatabaseAccess _databaseAccess;

    public CustomerViewModel(DatabaseAccess databaseAccess)
    {
        _databaseAccess = databaseAccess;
    }

    public ObservableCollection<Customer> Customers
    {
        get { return new ObservableCollection<Customer>(_databaseAccess.GetCustomers()); }
    }
}
