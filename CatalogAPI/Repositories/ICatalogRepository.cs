using CatalogAPI.Models;

namespace CatalogAPI.Repositories
{
    public interface ICatalogRepository
    {
       Task<Catalog> AddCatalog(Catalog Catalog);
        Task<Catalog> UpdateCatalog(Catalog Catalog);
//by user3
        Task<bool> DeleteCatalog(long CatalogId);
        Task<Catalog> GetCatalogById(long CatalogId);
        Task<IEnumerable<Catalog>> GetAllCatalog();
        




    }
}
