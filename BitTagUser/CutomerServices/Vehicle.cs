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
            List<VehicleModel> models = new List<VehicleModel>();
            models= await _httpclient.GetFromJsonAsync<List<VehicleModel>>("api/controller/GetVehicle");
            if(models!=null)
            {
                return models;
            }
            else
            {
                return new List<VehicleModel>();
            }
        }
        public async Task<List<VehicleModel>> GetVehicleModelByID(string id)
        {
            List<VehicleModel> models = new List<VehicleModel>();
            models = await _httpclient.GetFromJsonAsync<List<VehicleModel>>("api/controller/GetVehicleByID/" + id);
            if (models != null)
            {
                return models;
            }
            else
            {
                return new List<VehicleModel>();
            }
        }
        public async Task SaveVehicle(VehicleModel vm)
        {
            await _httpclient.PostAsJsonAsync("api/controller/AddVehicle", vm);
        }
        public async Task DeleteVehicle(Guid id)
        {
            await _httpclient.DeleteAsync("api/controller/DeleteVehicle/" + id);
        }
    }
}
