using FilteringSample.Model;
using System.Linq;

namespace FilteringSample.SqlServer
{
    public class SampleContextSeeder
    {
        private readonly SampleContext _context;

        public SampleContextSeeder(SampleContext context)
        {
            _context = context;
        }
        public void EnsureSeedData()
        {
            if(!_context.Ports.Any())
            {
                var ports = GetPorts();
                _context.AddRange(ports);
                _context.SaveChanges();
            }
        }

        private Port [] GetPorts()
        {
            var ports = new Port[]
            {
                new Port { Code = "AUSYD", Name = "Sydney" },
                new Port { Code = "AUCNB", Name = "Canberra" },
                new Port { Code = "AUMLB", Name = "Melbourne" },
                new Port { Code = "NZAKL", Name = "Auckland" },
                new Port { Code = "NZTRG", Name = "Tauranga" }
            };
            return ports;
        }
    }
}
