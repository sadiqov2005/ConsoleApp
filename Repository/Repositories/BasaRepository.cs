using DomainLayer.Coomon;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class BasaRepository<T> : BaseRepository<T> where T : BaseEntity
    {
        public void Create (T entity)
        {
            AppDbContext<T>.datas.Add(entity);
        }

        public bool Delete(T entity)
        {
              return  AppDbContext<T>.datas.Remove(entity);
        }

        public void Edit(int Id, T entity)
        {
          AppDbContext<T>.datas.FirstOrDefault(m=>m.Id == Id);
        }

        public List<T> GetAll()
        {
          return  AppDbContext<T>.datas;
        }
    }
}
