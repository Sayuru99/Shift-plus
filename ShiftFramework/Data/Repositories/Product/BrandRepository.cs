using Data.Entities.Product;
using ShiftSoftware.ShiftEntity.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Product;

public class BrandRepository : ShiftRepository<DB, Brand, BrandListDTO, BrandDTO>
{
    public BrandRepository(DB db) : base(db)
    {
    }


    /// <summary>
    /// Implemented only to show that default methods can be overriden
    /// </summary>
    /// <param name="showDeletedRows"></param>
    /// <param name="queryable"></param>
    /// <returns></returns>
    public override IQueryable<BrandListDTO> OdataList(bool showDeletedRows = false, IQueryable<Brand>? queryable = null)
    {
        return base.OdataList(showDeletedRows, queryable);
    }


    /// <summary>
    /// Implemented only to show that default methods can be overriden
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public override ValueTask<BrandDTO> ViewAsync(Brand entity)
    {
        //Do something here
        return base.ViewAsync(entity);
    }
}

