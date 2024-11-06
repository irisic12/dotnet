using BusTransportationModel.Data.Entities;

namespace BusTransportationModel.Data;

public interface IRepository<T> where T: BaseEntity
{
    IQueryable<T> GetAll();
    T? GetById(int id);
    T? GetById(Guid id);
    T Save(T entity);
    void Delete(T entity);
}