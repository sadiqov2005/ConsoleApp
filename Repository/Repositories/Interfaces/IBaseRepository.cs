using DomainLayer.Coomon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface BaseRepository<T> where T : BaseEntity
    {
        void Create (T entity);
        List<T> GetAll();
        void Edit (int Id,T entity);
        bool Delete (T entity );    
        
    }
}
