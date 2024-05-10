using BitTagModels;

namespace BitTagWebAPP.Services
{
    public interface IOrganizations
    {

        Task<List<OrganizationModel>> GetOrganizations();
        Task<List<OrganizationModel>> GetOrganizationsById(Guid id);
        Task SaveOrganizations(OrganizationModel om);
        Task DeleteOrganizations(Guid id);

    }
}
