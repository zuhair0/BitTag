using BitTagModels;

namespace BitTagWebAPP.Services
{
    public interface IOrgEmployees
    {
        Task<List<Orgnization_EmployeeModel>> GetOrgEmployees();
        Task SaveOrgEmployees(Orgnization_EmployeeModel oem);
        Task DeleteOrgEmployees(Guid id);
    }
}
