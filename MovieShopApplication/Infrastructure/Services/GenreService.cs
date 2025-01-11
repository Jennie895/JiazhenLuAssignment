using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.Services;

public class GenreService :BaseRepository<Genre>, IGenreService
{
    public GenreService(MovieDbContext movieDbContext) : base(movieDbContext)
    {
    }
}