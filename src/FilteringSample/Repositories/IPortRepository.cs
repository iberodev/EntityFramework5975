using FilteringSample.Model;
using System.Collections.Generic;

namespace FilteringSample.Repositories
{
    public interface IPortRepository
    {
        IEnumerable<Port> GetPortsFilteredInMemory(string filter);

        IEnumerable<Port> GetPortsFilteredInDatabase(string filter);
    }
}
