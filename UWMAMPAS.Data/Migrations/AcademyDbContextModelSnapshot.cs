// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UWMAMPAS.Data;

#nullable disable

namespace UWMAMPAS.Data.Migrations
{
    [DbContext(typeof(AcademyDbContext))]
    partial class AcademyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UWMAMPAS.Data.Models.Movie", b =>
                {
                    b.Property<Guid>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("UWMAMPAS.Data.Models.Performer", b =>
                {
                    b.Property<Guid>("PerformerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PerformerId");

                    b.HasIndex("MovieId");

                    b.ToTable("Performers");

                    b.HasData(
                        new
                        {
                            PerformerId = new Guid("0016c147-67ff-46f5-b2d7-f8afbbb61c16"),
                            Name = "Javier Bardem"
                        },
                        new
                        {
                            PerformerId = new Guid("4bff9bef-c675-4ef4-8db6-ddc967738b31"),
                            Name = "Benedict Cumberbatch"
                        });
                });

            modelBuilder.Entity("UWMAMPAS.Data.Models.Performer", b =>
                {
                    b.HasOne("UWMAMPAS.Data.Models.Movie", null)
                        .WithMany("ActorsActresses")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("UWMAMPAS.Data.Models.Movie", b =>
                {
                    b.Navigation("ActorsActresses");
                });
#pragma warning restore 612, 618
        }
    }
}
