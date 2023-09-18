using Domain.Domains.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.Generic;

public interface IGenericRepository<TDomain>
    where TDomain : BaseDomain
    
{
    Task<IEnumerable<TDomain>?> GetAll();
    Task<TDomain?> GetById(Guid Id);
    Task<TDomain?> GetByName(string Name);
    Task<TDomain?> Add(TDomain domain);
    Task<TDomain?> Update(TDomain domain);
    Task Delete(Guid Id);
}
