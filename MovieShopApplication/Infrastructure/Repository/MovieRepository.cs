using ApplicationCore.Contracts;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class MovieRepository: BaseRepository<Movie>, IMovieRepository 
{
    public MovieRepository(MovieDbContext movieDbContext) : base(movieDbContext)
    {
    }
}