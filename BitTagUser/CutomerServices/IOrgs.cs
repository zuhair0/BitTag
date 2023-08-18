using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public interface IOrgs
    {
        Task<List<OrganizationModel>> Getorgs();
    }
}
