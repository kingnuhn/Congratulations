using CongratulationsInfrasturture.BaseRepository;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongralutaionsAppData
{
    public interface IUserRepository 
    {
        Task<User> FindbyId(Guid Id,CancellationToken cancellationToken);
        IQueryable<User> GetAll();
        Task AddAsyncUser(User user, CancellationToken cancellationToken);
        Task DeleteAsyncUser(User user, CancellationToken cancellationToken);
        Task UpdateAsyncUser(User user, CancellationToken cancellationToken);


    }
}
