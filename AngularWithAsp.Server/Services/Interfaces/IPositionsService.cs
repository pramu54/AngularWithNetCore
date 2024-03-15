using AngularWithAsp.Server.Models;

namespace AngularWithAsp.Server.Services.Interfaces
{
    public interface IPositionsService
    {
        Task<IEnumerable<Position>> GetPositionsList();
    }
}
