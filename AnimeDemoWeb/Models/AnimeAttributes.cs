using System.Text.Json.Serialization;

namespace AnimeDemoWeb.Models
{
    public class AnimeAttributes
    {
        public DateTime? CreatedAt { get; set; }
        public string? Synopsis { get; set; }
        public string? Description { get; set; }
        public Titles? Titles { get; set; }
        //Оригинальное название
        public string? CanonicalTitle { get; set; }
        //100-бальная система оценивания
        public string? AverageRating { get; set; }
        //Год выпуска
        public string? StartDate { get; set; }
        public int? PopularityRank { get; set; }
        public int? RatingRank { get; set; }
        public string? AgeRatingGuide { get; set; }
        public string? Status { get; set; }
        public Posterimage? PosterImage { get; set; }
        public Coverimage? CoverImage { get; set; }
        public int? EpisodeCount { get; set; }
        public int? EpisodeLength { get; set; }
        public int? TotalLength { get; set; }
    }
}
