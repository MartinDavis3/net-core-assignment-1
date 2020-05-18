using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMusicAlbumn.Models
{
    public class MusicAlbumnItem
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Artist { get; set; }

        public int? Year { get; set; }

        public int? NumberOfTracks { get; set; }

        public string Genre { get; set; }

    }
}
