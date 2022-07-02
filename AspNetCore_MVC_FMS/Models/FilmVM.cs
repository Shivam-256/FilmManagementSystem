namespace AspNetCore_MVC_FMS.Models
{
    public class FilmVM
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
        public virtual ActorVM Actor { get; set; }
        public virtual CategoryVM Category { get; set; }
        public virtual LanguageVM Language { get; set; }
    }
}
