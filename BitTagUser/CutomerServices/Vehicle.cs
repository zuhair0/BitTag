using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public class Vehicle:IVehicle
    {
        private readonly HttpClient _httpclient;
        public Vehicle(HttpClient httpClient)
        {
            this._httpclient = httpClient;
        }
        public async Task<List<VehicleModel>> GetVehicleModels()
        {
            return await _httpclient.GetFromJsonAsync<List<VehicleModel>>("api/controller/GetVehicle");
        }
        public async Task SaveVehicle(VehicleModel vm)
        {
            await _httpclient.PostAsJsonAsync("api/controller/AddVehicle", vm);
        }
        public async Task DeleteVehicle(string id)
        {
            await _httpclient.DeleteAsync("api/controller/DeleteVehicle"+id);
        }
    }
}
