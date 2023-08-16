using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public interface ICustomerWorkInfo
    {
        Task<List<CustomerWorkInfoModel>> GetCustomerWorkInfo();
        Task SaveCustomerWorkInfo(CustomerWorkInfoModel cwi);
        Task DeleteCustomerWorkInfo(Guid id);
    }
}
