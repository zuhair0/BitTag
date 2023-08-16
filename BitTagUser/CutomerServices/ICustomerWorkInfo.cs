using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public interface ICustomerWorkInfo
    {
        Task<List<CustomerWorkInfo>> GetCustomerWorkInfo();
        Task SaveCustomerWorkInfo(CustomerWorkInfo cwi);
        Task DeleteCustomerWorkInfo(Guid id);
    }
}
