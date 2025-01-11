using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.Services;

public class CastService :BaseRepository<Cast>, ICastService
{
    public CastService(MovieDbContext movieDbContext) : base(movieDbContext)
    {
    }
}