using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public class Orgs:IOrgs
    {
        private readonly HttpClient _httpClient;
        Orgs(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<OrganizationModel>> Getorgs()
        {
            return await _httpClient.GetFromJsonAsync<List<OrganizationModel>>("api/controller/GetOrganization");
        }
    }
}
