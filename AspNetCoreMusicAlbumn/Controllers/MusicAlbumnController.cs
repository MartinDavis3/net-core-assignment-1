using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMusicAlbumn.Services;
using AspNetCoreMusicAlbumn.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMusicAlbumn.Controllers
{
    public class MusicAlbumnController : Controller
    {
        private readonly IMusicAlbumnItemService _musicAlbumnItemService;

        public MusicAlbumnController(IMusicAlbumnItemService musicAlbumnItemService)
        {
            _musicAlbumnItemService = musicAlbumnItemService;
        }
        public async Task<IActionResult> Index()
        {
            var items = await _musicAlbumnItemService.GetAllItemsAsync();

            var model = new MusicAlbumnViewModel()
            {
                Items = items
            };

            return View(model);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddItem(MusicAlbumnItem newItem)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _musicAlbumnItemService.AddItemAsync(newItem);
            if (!successful)
            {
                return BadRequest("Could not add item");
            }
            return RedirectToAction("Index");
        }

    }
}
