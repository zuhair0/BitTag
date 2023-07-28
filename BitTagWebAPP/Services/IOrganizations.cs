using BitTagModels;

namespace BitTagWebAPP.Services
{
    public interface IOrganizations
    {

        Task<List<OrganizationModel>> GetOrganizations();
        Task SaveOrganizations(OrganizationModel om);
        Task DeleteOrganizations(Guid id);

    }
}
