using System.ComponentModel.DataAnnotations;

namespace MusicAPI.Models
{
    public class Album
    {
        //Properties
        public int AlbumId { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        public DateOnly ReleaseDate { get; set; }

        // Koppling till flera låtar
        public List<Music>? Songs { get; set; } // Navigation Property

    }
}