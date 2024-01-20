using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public class Orgs:IOrgs
    {
        private readonly HttpClient _httpClient;
        public Orgs(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<OrganizationModel>> Getorgs()
        {
            List<OrganizationModel> organizations = new List<OrganizationModel>();
            organizations= await _httpClient.GetFromJsonAsync<List<OrganizationModel>>("api/controller/GetOrganizations");
            if (organizations != null)
            {
                return organizations;
            }
            else
            {
                return new List<OrganizationModel>();
            }
        }
    }
}
