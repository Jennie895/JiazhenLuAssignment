using ApplicationCore.Contracts;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class PurchaseRepository: BaseRepository<Purchase>, IPurchaseRepository
{
    public PurchaseRepository(MovieDbContext movieDbContext) : base(movieDbContext)
    {
    }
}