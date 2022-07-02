using System;

namespace AspNetCore_WebApi_FMS.Data
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int LanguageId { get; set; }
        public int RentalDuration { get; set; }
        public int Length { get; set; }
        public decimal ReplacementCost { get; set; }
        public decimal Rating { get; set; }
        public string SpecialFeatures { get; set; }
        public int ActorId { get; set; }
        public int CategoryId { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Category Category { get; set; }
        public virtual Language Language { get; set; }

    }
}
