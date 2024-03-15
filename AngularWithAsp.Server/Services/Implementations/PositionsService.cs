using AngularWithAsp.Server.Data;
using AngularWithAsp.Server.Models;
using AngularWithAsp.Server.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AngularWithAsp.Server.Services.Implementations
{
    public class PositionsService : IPositionsService
    {
        private readonly FootballDbContext _context;

        public PositionsService(FootballDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Position>> GetPositionsList()
        {
            return await _context.Positions
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync();
        }
    }
}
