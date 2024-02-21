using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public interface IVehicle
    {
        Task<List<VehicleModel>> GetVehicleModels();
        Task<List<VehicleModel>> GetVehicleModelByID(string id);
        Task SaveVehicle(VehicleModel vm);
        Task DeleteVehicle(Guid id);
    }
}
