using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public interface ICustomerWorkInfo
    {
        Task<List<CustomerWorkInfoModel>> GetCustomerWorkInfo();
        Task<List<CustomerWorkInfoModel>> GetCustomerWorkInfoByID(string id);
        Task SaveCustomerWorkInfo(CustomerWorkInfoModel cwi);
        Task DeleteCustomerWorkInfo(Guid id);
    }
}
