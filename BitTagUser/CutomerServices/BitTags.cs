using BitTagModels;

namespace BitTagUser.CutomerServices
{
    public class BitTags:IBitTag
    {
        private readonly HttpClient _httpClient;
        public BitTags(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task SaveBitTagUser(BitTagUserModel bum)
        {
            await _httpClient.PostAsJsonAsync("api/controller/SaveBitTagUser", bum);
        }

    }
}
