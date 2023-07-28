using BitTagModels;
using System.Net.Http.Json;

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

        public async Task SaveOrganizations(OrganizationModel om)
        {
            await _httpClient.PostAsJsonAsync("api/controller/AddOrganization",om);
        }
        public async Task DeleteOrganizations(Guid id)
        {
            await _httpClient.DeleteAsync("api/controller/DeleteOrganization/"+id);
        }
    }
}
