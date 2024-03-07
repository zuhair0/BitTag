using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public interface IBitTag
    {
        Task<List<BitTagDetailsModel>> GetBitT();
		Task<List<BitTagDetailsModel>> GetBitTByID(string qr);

		Task SaveBitTags(BitTagDetailsModel btdm);
        Task DeleteBitTag(Guid id);
    }
}
