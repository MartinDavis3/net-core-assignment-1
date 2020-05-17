using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMusicAlbumn.Models;

namespace AspNetCoreMusicAlbumn.Services
{
    public interface IMusicAlbumnService
    {
        Task<MusicAlbumn[]> GetMusicAlbumnsAsync();
        Task<bool> AddMusicAlbumnAsync(MusicAlbumn newMusicAlbumn);
    }
}
