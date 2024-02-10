using Data.Entities.Product;
using ShiftSoftware.ShiftEntity.EFCore;

namespace Data.Repositories;

public class CountryRepository : ShiftRepository<DB, Country, CountryDTO, CountryDTO>
{
    public CountryRepository(DB db, AutoMapper.IMapper mapper) : base(db)
    {

    }
}
