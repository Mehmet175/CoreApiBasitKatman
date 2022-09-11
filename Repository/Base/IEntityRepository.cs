using DenemeApi.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DenemeApi.Repository
{
    public interface IEntityRepository<T> : IDisposable
    {
        public BaseModel<IEnumerable<T>> GetAll();
        BaseModel<T> Get(Expression<Func<T, bool>> filterl);
    }
}
