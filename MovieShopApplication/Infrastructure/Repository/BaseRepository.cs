using ApplicationCore.Contracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
namespace Infrastructure.Repository;

public class BaseRepository<T> : IRepository<T> where T : class
{
    private readonly MovieDbContext movieDbContext;

    public BaseRepository(MovieDbContext movieDbContext)
    {
        this.movieDbContext = movieDbContext;
    }
    public int Insert(T entity)
    {
        movieDbContext.Set<T>().Add(entity);
        return movieDbContext.SaveChanges();
    }

    public int Update(T entity, int id)
    {
        movieDbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return movieDbContext.SaveChanges();
    }

    public int Delete(int id)
    {
        T obj = GetById(id);
        if (obj != null)
        {
            movieDbContext.Set<T>().Remove(obj);
        }
        return movieDbContext.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return movieDbContext.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return movieDbContext.Set<T>().Find(id);
    }

    public IEnumerable<T> Search(Func<T, bool> predicate)
    {
        return movieDbContext.Set<T>().Where(predicate);
    }
}
