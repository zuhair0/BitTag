namespace BitTagUser.CutomerServices
{
    public class CustomerWorkInfo:ICustomerWorkInfo
    {
        private readonly HttpClient _httpClient;
        public CustomerWorkInfo(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<CustomerWorkInfo>> GetCustomerWorkInfo()
        {
            return await _httpClient.GetFromJsonAsync<List<CustomerWorkInfo>>("api/controller/GetCustWorkInfo");
        }
        public async Task SaveCustomerWorkInfo(CustomerWorkInfo cwi)
        {
            await _httpClient.PostAsJsonAsync("api/controller/AddWorkInfo", cwi);
        }
        public async Task DeleteCustomerWorkInfo(Guid id)
        {
            await _httpClient.DeleteAsync("api/controller/DeleteWorkInfo/" + id);
        }

    }
}
