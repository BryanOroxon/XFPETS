using System.Collections.Generic;
using System.Threading.Tasks;
using XFPETS.Models;

namespace XFPETS.Services
{
    public interface IDataService
    {
        Task<IEnumerable<Pets>> GetPetsAsync();
    }
}
