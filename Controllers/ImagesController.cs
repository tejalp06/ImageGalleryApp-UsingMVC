using ImageGalleryAppMVC.Data;
using ImageGalleryAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageGalleryAppMVC.Controllers
{
    public class ImagesController : Controller
    {
        private readonly ImageContext db;
        private readonly IWebHostEnvironment env;
        public ImagesController(ImageContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public IActionResult Index()
        {
            var images = db.Images.ToList();

            return View(images);
        }
        public IActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if(file!=null && file.Length > 0)
            {
                var uploads = Path.Combine(env.WebRootPath, "uploads");
                Directory.CreateDirectory(uploads);

                var filename = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var filePath = Path.Combine(uploads, filename);

                using (var stram = new FileStream(filePath,FileMode.Create))
                {
                    await file.CopyToAsync(stram);
                }
                var image = new Image { Url = "/uploads/" + filename };
                db.Images.Add(image);
                 await db.SaveChangesAsync();

                return RedirectToAction("Index");


            }
            return View();

        }
    }
}
