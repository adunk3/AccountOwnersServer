using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.ExtendedModels;
using Entities.Models;

namespace Contracts
{
    public interface IOwnerRepository  
    {
        Task<IEnumerable<Owner>> GetAllOwnersAsync();
        Task<Owner> GetOwnerByIdAsync(Guid ownerId);
        Task<OwnerExtended> GetOwnerWithDetailsAsync(Guid ownerId);
        Task CreateOwnerAsync(Owner owner);
        Task UpdateOwnerAsync(Owner dbOwner, Owner owner);
        Task DeleteOwnerAsync(Owner owner);
    }
}
