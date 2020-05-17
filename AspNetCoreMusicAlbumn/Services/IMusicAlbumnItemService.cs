using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreMusicAlbumn.Models;

namespace AspNetCoreMusicAlbumn.Services
{
    public interface IMusicAlbumnItemService
    {
        Task<MusicAlbumnItem[]> GetAllItemsAsync();
        Task<bool> AddItemAsync(MusicAlbumnItem newItem);
    }
}
