using ShiftSoftware.ShiftEntity.EFCore;

namespace Data.Repositories.Product;

public class ProductRepository : ShiftRepository<DB, Entities.Product.Product, ProductListDTO, ProductDTO>
{
    public ProductRepository(DB db) :
        base(db,
                x => x.IncludeRelatedEntitiesWithFindAsync(
                    y => y.Include(z => z.Brand),
                    y => y.Include(z => z.CountryOfOrigin)
                ))
    {
    }
}
