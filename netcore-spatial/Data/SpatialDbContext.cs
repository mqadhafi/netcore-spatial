using System;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace netcore_spatial.Data
{
    public class SpatialDbContext : DbContext
    {
        public DbSet<Place> Places { get; set; }

        public SpatialDbContext(DbContextOptions<SpatialDbContext> options)
         : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql("connectionstring", x => x.UseNetTopologySuite());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("postgis");

            modelBuilder
                .ApplyConfiguration(new PlaceConfiguration());

            GeometryFactory geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            // longitude as the first parameter(x) and the latitude as the second parameter(y)
            modelBuilder.Entity<Place>()
                .HasData(new Place
                {
                    Id = Guid.NewGuid(),
                    Name = "Monumen Nasional",
                    Point = geometryFactory.CreatePoint(new Coordinate(106.8232042, -6.1778625))
                });

            modelBuilder.Entity<Place>()
                .HasData(new Place
                {
                    Id = Guid.NewGuid(),
                    Name = "Tanah Abang",
                    Point = geometryFactory.CreatePoint(new Coordinate(106.7899549, -6.2054172))
                });

            modelBuilder.Entity<Place>()
                .HasData(new Place
                {
                    Id = Guid.NewGuid(),
                    Name = "Soekarno-Hatta International Airport",
                    Point = geometryFactory.CreatePoint(new Coordinate(106.6515171, -6.1275282))
                });

            modelBuilder.Entity<Place>()
                .HasData(new Place
                {
                    Id = Guid.NewGuid(),
                    Name = "Halim Perdanakusuma Airport",
                    Point = geometryFactory.CreatePoint(new Coordinate(106.88239, -6.2653365))
                });

            modelBuilder.Entity<Place>()
                .HasData(new Place
                {
                    Id = Guid.NewGuid(),
                    Name = "Trans Studio Bandung",
                    Point = geometryFactory.CreatePoint(new Coordinate(107.6001837, -6.9072212))
                });

            modelBuilder.Entity<Place>()
                .HasData(new Place
                {
                    Id = Guid.NewGuid(),
                    Name = "Gedung Sate",
                    Point = geometryFactory.CreatePoint(new Coordinate(107.6230286, -6.8928316))
                });

            modelBuilder.Entity<Place>()
               .HasData(new Place
               {
                   Id = Guid.NewGuid(),
                   Name = "Surabaya Town Square",
                   Point = geometryFactory.CreatePoint(new Coordinate(112.7280482, -7.2946663))
               });
        }
    }
}