using BitTagModels;

namespace BitTagWebAPP.Services
{
    public class OrgEmployees:IOrgEmployees
    {
        private readonly HttpClient _httpClient;
        public OrgEmployees(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<Orgnization_EmployeeModel>> GetOrgEmployees()
        {
            return await _httpClient.GetFromJsonAsync<List<Orgnization_EmployeeModel>>("api/controller/GetOrgEmployees");
        }
        public async Task<List<Orgnization_EmployeeModel>> GetOrgEmployeesByID(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<List<Orgnization_EmployeeModel>>("api/controller/GetOrgEmployees/"+id);
        }
        public async Task SaveOrgEmployees(Orgnization_EmployeeModel oem)
        {
            await _httpClient.PostAsJsonAsync("api/controller/AddOrgEmployee", oem);
        }
        public async Task DeleteOrgEmployees(Guid id)
        {
            await _httpClient.DeleteAsync("api/controller/DeleteOrgEmployee/"+id);
        }
    }
}
