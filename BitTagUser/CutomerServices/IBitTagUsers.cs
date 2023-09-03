using BitTagModels;

namespace BitTagUser.CutomerServices
{
	public interface IBitTagUsers
	{
		Task SaveBitTagUser(BitTagUserModel bum);
	}
}
