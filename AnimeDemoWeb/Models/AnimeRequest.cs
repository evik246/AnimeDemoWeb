namespace AnimeDemoWeb.Models
{
    public class AnimeRequest
    {
        private static readonly string link = "https://kitsu.io/api/edge";

        public async Task<AnimeModel?> GetAnime(int id)
        {
            var anime = await RequestHelper<AnimeModel>.Get($"{link}/anime/{id}");
            if (anime != null)
            {
                return anime;
            }
            return default;
        }

        public async Task<CategoriesModel?> GetAnimeCategories(int id)
        {
            var categories = await RequestHelper<CategoriesModel>.Get($"{link}/anime/{id}/categories");
            if (categories != null)
            {
                return categories;
            }
            return default;
        }

        public async Task<int?> GetCount()
        {
            var collection = await RequestHelper<AnimeCollection>.Get($"{link}/anime?sort=-createdAt&page[limit]=1");
            if (collection != null && collection.Data.Any())
            {
                int count = int.Parse(collection.Data.FirstOrDefault()!.Id);
                return count;
            }
            return default;
        }

        public async Task<AnimeModel?> GenerateAnime()
        {
            int count = (int) await GetCount();
            if (count > 0)
            {
                AnimeModel? anime;
                do
                {
                    int ramdomId = Random.Shared.Next(1, count);
                    anime = await GetAnime(ramdomId);
                } while (anime == null);

                return anime;
            }
            return default;
        }
    }
}
