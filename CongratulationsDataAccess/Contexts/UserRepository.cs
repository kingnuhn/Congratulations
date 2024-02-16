using CongralutaionsAppData;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongratulationsDataAccess.Contexts
{
    public class UserRepository : IUserRepository
    {
        public Task AddAsyncUser(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsyncUser(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindbyId(Guid Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsyncUser(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
