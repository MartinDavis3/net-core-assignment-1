using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMusicAlbumn.Models
{
    public class MusicAlbumn
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Artist { get; set; }

        public int? Year { get; set; }

        public int? NumberOfTracks { get; set; }

    }
}
