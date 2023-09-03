using BitTagModels;

namespace BitTagUser.CutomerServices
{
	public class BitTaaguser:IBitTagUsers
	{
		private readonly HttpClient _httpClient;
		public BitTaaguser(HttpClient httpClient)
		{
			this._httpClient = httpClient;
		}

		public async Task SaveBitTagUser(BitTagUserModel bum)
		{
			await _httpClient.PostAsJsonAsync("api/controller/SaveBitTagUser", bum);
		}
	}
}
