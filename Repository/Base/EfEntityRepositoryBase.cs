using DenemeApi.EF;
using DenemeApi.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DenemeApi.Repository.Base
{
    public abstract class EfEntityRepositoryBase<TEntity>
       : IEntityRepository<TEntity>
       where TEntity : class, new()
    {

        PVSCADA2022Context context;

        public EfEntityRepositoryBase()
        {
            context = new PVSCADA2022Context();
        }

        public void Dispose()
        {
           
        }

        public BaseModel<TEntity> Get(Expression<Func<TEntity, bool>> filterl)
        {
            try
            {
                var data = context.Set<TEntity>().FirstOrDefault(filterl);
                return new BaseModel<TEntity>()
                {
                    Status = data == null ? StatusEnum.empty : StatusEnum.success,
                    Message = null,
                    Data = data,
                };
            }
            catch (Exception e)
            {
                return new BaseModel<TEntity>()
                {
                    Status = StatusEnum.error,
                    Message = e.Message,
                    Data = null,
                };
            }            
        }

        public BaseModel<IEnumerable<TEntity>> GetAll()
        {

            try
            {
                var data = context.Set<TEntity>();
                return new BaseModel<IEnumerable<TEntity>>()
                {
                    Status = data == null ? StatusEnum.empty : StatusEnum.success,
                    Message = null,
                    Data = data,
                };
            }
            catch (Exception e)
            {
                return new BaseModel<IEnumerable<TEntity>>()
                {
                    Status = StatusEnum.error,
                    Message = e.Message,
                    Data = null,
                };
            }
        }
    }
}
