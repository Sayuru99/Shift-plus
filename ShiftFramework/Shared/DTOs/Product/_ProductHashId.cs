﻿using ShiftSoftware.ShiftEntity.Model.HashIds;


namespace Shared.DTOs.Product;

public class _ProductHashId : JsonHashIdConverterAttribute<_ProductHashId>
{
    public _ProductHashId() : base(5) { }
}

