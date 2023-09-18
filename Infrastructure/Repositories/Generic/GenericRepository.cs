using AutoMapper;
using Domain.Domains.Base;
using Domain.Repositories.Generic;
using Infrastructure.DatabaseContext;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories.Generic
{
    internal class GenericRepository<TEntity, TDomain> : IGenericRepository<TDomain>
        where TEntity : BaseEntity
        where TDomain : BaseDomain
    {
        private readonly TicketDbContext _dbContext;
        private readonly ILogger _logger;
        private readonly string _className;
        private readonly IMapper _mapper;
        public GenericRepository(TicketDbContext ticketDbContext, ILogger logger, IMapper mapper)
        {
            _dbContext = ticketDbContext;
            _logger = logger;
            _className = typeof(GenericRepository<TEntity, TDomain>).Name;
            _mapper = mapper;

        }

        public async Task<TDomain?> Add(TDomain domain)
        {
            if (domain == null)
            {
                _logger.LogError("Class : {className} - Method: {method} - Provided domain is null", _className, nameof(Add));
                return null;
            }

            var entity = _mapper.Map<TEntity>(domain);           
            _ = _dbContext.Add(entity);
            var changes = await _dbContext.SaveChangesAsync();

            if (changes > 0)
            {
                var addedDomain = _mapper.Map<TDomain>(entity);
                return addedDomain;
            }
            return null;
            
        }

        public Task Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TDomain>?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TDomain?> GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<TDomain?> GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<TDomain?> Update(TDomain domain)
        {
            throw new NotImplementedException();
        }
    }
}
