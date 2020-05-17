using AspNetCoreMusicAlbumn.Data;
using AspNetCoreMusicAlbumn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMusicAlbumn.Services
{
    public class MusicAlbumnService : IMusicAlbumnService
    {
        private readonly ApplicationDbContext _context;
        public MusicAlbumnService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<MusicAlbumn[]> GetMusicAlbumnsAsync()
        {
            return await _context.MusicAlbumns
            .ToArrayAsync();
        }
        public async Task<bool> AddMusicAlbumnAsync(MusicAlbumn newMusicAlbumn)
        {
            newMusicAlbumn.Id = Guid.NewGuid();
            _context.MusicAlbumns.Add(newMusicAlbumn);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }

}
