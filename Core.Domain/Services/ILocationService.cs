using System.Collections.Generic;

namespace Core.Domain.Services
{
    public interface ILocationService
    {
        IEnumerable<WarehouseLocation> GetWarehouseLocations();
    }
}