using System.ComponentModel.DataAnnotations;

namespace BlazorTask2.Components
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public float? Rate { get; set; }

        public int NumberOfRates { get; set; }
        public float AverageRate => NumberOfRates == 0 ? 0 : (float)Rate / NumberOfRates;
        public string? Url { get; set; }
    }
}


