using ApplicationCore.Contracts;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class UserRepository :BaseRepository<User>, IUserRepository
{
    public UserRepository(MovieDbContext movieDbContext) : base(movieDbContext)
    {
    }
}