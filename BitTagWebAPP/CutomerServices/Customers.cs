using BitTagModels;

namespace BitTagWebAPP.CutomerServices
{
    public class Customers:ICustomer
    {
        private readonly HttpClient _httpClient;
        public Customers(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<CustomersModel>> GetCustomers()
        {
            return await _httpClient.GetFromJsonAsync<List<CustomersModel>>("api/controller/GetCustomer");
        }
        public async Task SaveCustomers(CustomersModel cm)
        {
            await _httpClient.PostAsJsonAsync("api/controller/AddCustomer",cm);
        }
        public async Task DeleteCustomer(Guid id)
        {
            await _httpClient.DeleteAsync("api/controller/DeleteCustomer/" + id);
        }

    }
}
