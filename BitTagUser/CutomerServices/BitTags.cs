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
        public async Task<List<BitTagDetailsModel>> GetBitT()
        {
            List<BitTagDetailsModel> bitTagDetails = new List<BitTagDetailsModel>();
            bitTagDetails = await _httpClient.GetFromJsonAsync<List<BitTagDetailsModel>>("api/controller/GetBitTagDetails");
            if(bitTagDetails!= null)
            {
                return bitTagDetails;
            }
            else
            {
                return new List<BitTagDetailsModel>();
            }
        }
        public async Task SaveBitTags(BitTagDetailsModel btdm)
        {
            await _httpClient.PostAsJsonAsync("api/controller/AddBitTagDetails", btdm);
        }
        public async Task DeleteBitTag(Guid id)
        {
            await _httpClient.DeleteAsync("api/controller/DeleteBitTagDetails/" + id);
        }
    }
}
