using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public interface IVehicle
    {
        Task<List<VehicleModel>> GetVehicleModels();
        Task SaveVehicle(VehicleModel vm);
        Task DeleteVehicle(string id);
    }
}
