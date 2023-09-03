using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public interface IBitTag
    {
        Task SaveBitTagUser(BitTagUserModel bum);
    }
}
