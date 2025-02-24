using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MusicAPI.Models
{
    public class Music
    {
        //Properties
        public int MusicId { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        public int Length { get; set; }
        [Required]
        public string? Category { get; set; }

        //Koppling till Album
        public int AlbumId { get; set; } // Foreign Key
        [JsonIgnore]
        public Album? Album { get; set; } // Navigation Property


    }
}