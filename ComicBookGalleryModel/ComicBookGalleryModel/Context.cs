using System.Data.Entity;
using ComicBookGalleryModel.Models;

namespace ComicBookGalleryModel;

public class Context : DbContext
{
    public DbSet<ComicBook> ComicBooks { get; set; }
}