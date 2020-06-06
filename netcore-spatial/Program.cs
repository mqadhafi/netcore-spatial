using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netcore_spatial.Data;
using NetTopologySuite.Geometries;

namespace netcore_spatial
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<SpatialDbContext>().UseNpgsql("connectionstring").Options;
            using (var context = new SpatialDbContext(options))
            {
                // Mayestik Market
                Point query = new Point(106.7888256, -6.2408434) { SRID = 4326 };

                // Tanjung Priok
                //Point query = new Point(106.8811533, -6.1076897) { SRID = 4326 };

                // RSUP Dr.Sitanala
                //Point query = new Point(106.6381633, -6.1514835) { SRID = 4326 };

                // Tanjung Perak Surabaya
                //Point query = new Point(112.7233752, -7.2219498) { SRID = 4326 };

                // multiply by 1000M
                const double radiusMeters = 100 * 1000;
                var places = await context
                    .Places
                    .Where(x => x.Point.Distance(query) <= radiusMeters)
                    .OrderBy(x => x.Point.Distance(query))
                    .Select(t => new
                    {
                        t.Name,
                        Distance = t.Point.Distance(query) / 1000
                    })
                    .ToListAsync();

                foreach (var place in places)
                    Console.WriteLine($"{place.Name}, {Math.Round(place.Distance)} KM");
            }

            Console.ReadLine();
        }
    }
}