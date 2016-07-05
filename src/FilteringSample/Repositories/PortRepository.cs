using System.Collections.Generic;
using FilteringSample.SqlServer;
using FilteringSample.Model;
using System.Linq;
using System;

namespace FilteringSample.Repositories
{
    public class PortRepository : IPortRepository
    {
        private readonly SampleContext _context;

        public PortRepository(SampleContext context)
        {
            _context = context;
        }

        public IEnumerable<Port> GetPortsFilteredInDatabase(string filter)
        {
            var query = _context.Ports.Where(p => p.Code.StartsWith(filter));
            return query.ToList();
        }

        public IEnumerable<Port> GetPortsFilteredInMemory(string filter)
        {
            var allPorts = _context.Ports.ToList();
            var query = allPorts.Where(p => p.Code.StartsWith(filter));
            return query.ToList();
        }
    }
}
