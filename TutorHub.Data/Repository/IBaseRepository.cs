using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TutorHub.Data.Models;
using TutorHub.Data.Resources;

namespace TutorHub.Data.Repository
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetList(int type);
        T FindById(int id);
        string Create(T user);
        string Update(T entity);
        string Delete(int id);
    }
}