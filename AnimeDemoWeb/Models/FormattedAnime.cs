using System.Globalization;

namespace AnimeDemoWeb.Models
{
	public class FormattedAnime
	{
        public string PosterUrl { get; set; } = string.Empty;
		public string CanonicalTitle { get; set; } = string.Empty;
		public string JapaneseTitle { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
		private string _startDate = string.Empty;
		public string StartDate 
		{ 
			get { return _startDate; }
			set 
			{
				if (value != null)
				{
					string pattern = "yyyy-MM-dd";
					DateTime parsedDate;
					DateTime.TryParseExact(value, pattern, null, DateTimeStyles.None, out parsedDate);
					_startDate = parsedDate.Year.ToString();
				}
			} 
		}
		public string Status { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		public FormattedAnime()
		{
		}

		public FormattedAnime(AnimeModel? model)
		{
			if (model != null)
			{
				AnimeAttributes attributes = model.Data.Attributes;
				PosterUrl = attributes.PosterImage!.Original!;
				CanonicalTitle = attributes.CanonicalTitle!;
				Rating = attributes.AverageRating!;
				StartDate = attributes.StartDate!;
				Status = attributes.Status!;
				Description = attributes.Description!;
				JapaneseTitle = attributes.Titles!.ja_jp!;
			}
		}
	}
}
