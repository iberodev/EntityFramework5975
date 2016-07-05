using FilteringSample.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilteringSample.SqlServer.Mapping
{
public class PortMap
{
    public PortMap(EntityTypeBuilder<Port> entityBuilder)
    {
        entityBuilder.HasKey(p => p.Code);

        entityBuilder.Property(p => p.Code)
            .HasColumnType("char(5)");

        entityBuilder.Property(p => p.Name)
            .HasMaxLength(65);
    }
}
}
