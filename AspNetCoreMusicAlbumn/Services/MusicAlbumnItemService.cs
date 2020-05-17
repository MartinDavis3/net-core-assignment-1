using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMusicAlbumn.Data;
using AspNetCoreMusicAlbumn.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMusicAlbumn.Services
{
    public class MusicAlbumnItemService : IMusicAlbumnItemService
    {
        private readonly ApplicationDbContext _context;
        public MusicAlbumnItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<MusicAlbumnItem[]> GetAllItemsAsync()
        {
            return await _context.Items
            .ToArrayAsync();
        }
        public async Task<bool> AddItemAsync(MusicAlbumnItem newItem)
        {
            newItem.Id = Guid.NewGuid();
            _context.Items.Add(newItem);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }

}
