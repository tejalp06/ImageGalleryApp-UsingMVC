using ImageGalleryAppMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageGalleryAppMVC.Data
{
    public class ImageContext: DbContext
    {
        public ImageContext(DbContextOptions<ImageContext>options):base(options) { }
        public DbSet<Image> Images { get; set; }
      
    }
}
