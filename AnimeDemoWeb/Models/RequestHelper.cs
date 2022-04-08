
namespace AnimeDemoWeb.Models
{
    public static class RequestHelper<Type>
    {
        public static async Task<Type?> Get(string url)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Type>();
                }
                return default;
            }
        }
    }
}
