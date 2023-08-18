using BitTagModels;
using System.Reflection;

namespace BitTagWebAPP.CutomerServices
{
    public class Customer:ICustomer
    {
        private readonly HttpClient _httpClient;
        public Customer(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<CustomersModel>> GetCustomers()
        {
            List<CustomersModel> customers = new List<CustomersModel>();
            customers= await _httpClient.GetFromJsonAsync<List<CustomersModel>>("api/controller/GetCustomer");
            if (customers != null)
            {
                return customers;
            }
            else
            {
                return new List<CustomersModel>();
            }
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
