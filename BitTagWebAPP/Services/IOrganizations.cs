using BitTagModels;

namespace BitTagWebAPP.Services
{
    public interface IOrganizations
    {
        Task<List<OrganizationModel>> GetOrganizations();
    }
}
