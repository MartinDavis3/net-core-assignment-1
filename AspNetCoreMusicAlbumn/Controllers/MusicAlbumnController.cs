using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//Have not yet created the Services, so will see an error here
using AspNetCoreMusicAlbumn.Services;
using AspNetCoreMusicAlbumn.Models;

namespace AspNetCoreMusicAlbumn.Controllers
{
    public class MusicAlbumnController : Controller
    {
        //Have not yet defined the MusicAlbumnService, so will see errors here.
        private readonly IMusicAlbumnService _musicAlbumnService;

        public MusicAlbumnController(IMusicAlbumnService musicAlbumnService)
        {
            _musicAlbumnService = musicAlbumnService;
        }
        public async Task<IActionResult> Index()
        {
            var musicAlbumns = await _musicAlbumnService.GetMusicAlbumnsAsync();

            //Have not yet written the ViewModel, so will see an error here.
            var model = new MusicAlbumnViewModel()
            {
                MusicAlbumns = musicAlbumns
            };

            return View(model);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMusicAlbumn(MusicAlbumn newMusicAlbumn)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _musicAlbumnService.AddMusicAlbumnAsync(newMusicAlbumn);
            if (!successful)
            {
                return BadRequest("Could not add item");
            }
            return RedirectToAction("Index");
        }

    }
}
