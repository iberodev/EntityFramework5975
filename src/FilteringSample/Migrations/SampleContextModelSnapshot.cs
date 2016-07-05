using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FilteringSample.SqlServer;

namespace FilteringSample.Migrations
{
    [DbContext(typeof(SampleContext))]
    partial class SampleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FilteringSample.Model.Port", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("char(5)");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 65);

                    b.HasKey("Code");

                    b.ToTable("Ports");
                });
        }
    }
}
