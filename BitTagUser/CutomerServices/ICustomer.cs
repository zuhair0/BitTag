using BitTagModels;

namespace BitTagWebAPP.CutomerServices
{
    public interface ICustomer
    {
        Task<List<CustomersModel>> GetCustomers();
        Task SaveCustomers(CustomersModel cm);
        Task DeleteCustomer(Guid id);
    }
}
