using System;
using ShiftSoftware.ShiftEntity.Model.HashIds;


namespace Shared.DTOs.ProductCategory;

public class _ProductCategoryHashId : JsonHashIdConverterAttribute<_ProductCategoryHashId>
{
    public _ProductCategoryHashId() : base(5) { }
}

