using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public interface ICustomer
    {
        Task<List<CustomersModel>> GetCustomers();
        Task<List<CustomersModel>> GetCustomerByID(string cnic);
        Task SaveCustomers(CustomersModel cm);
        Task DeleteCustomer(Guid id);
    }
}
