using BitTagModels;

namespace BitTagWebAPP.Services
{
    public class Organizations:IOrganizations
    {
        private readonly HttpClient _httpClient;
        public Organizations(HttpClient httpClient)
        {
           this._httpClient = httpClient;
        }
        public async Task<List<OrganizationModel>> GetOrganizations()
        {
            return await _httpClient.GetFromJsonAsync<List<OrganizationModel>>("api/controller/GetOrganization");
        }
    }
}
