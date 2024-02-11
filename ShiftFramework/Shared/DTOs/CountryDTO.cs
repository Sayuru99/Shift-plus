using ShiftSoftware.ShiftEntity.Model;
using ShiftSoftware.ShiftEntity.Model.Dtos;

namespace Shared.DTOs;

[ShiftEntityKeyAndName(nameof(ID), nameof(Name))]
public class CountryDTO : ShiftEntityMixedDTO
{
    public override string? ID { get; set; }
    public string Name { get; set; } = default!;
}

