using System.ComponentModel.DataAnnotations;

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

    }
}