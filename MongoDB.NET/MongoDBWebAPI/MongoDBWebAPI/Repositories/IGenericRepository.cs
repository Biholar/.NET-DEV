using MongoDBWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBWebAPI.Repositories
{
    public interface IGenericRepository <TEnitity, TId> where TEnitity : class , IEntity <TId>
    {
        // Create
        Task Create(TEnitity enitity);

        // Read
        Task<TEnitity> Get(TId Id);
        Task<IEnumerable<TEnitity>> Get();
       

        // Update
        Task Update(TId Id, TEnitity enitity);

        // Delete
        Task<bool> Delete(TId Id);
    }
}
