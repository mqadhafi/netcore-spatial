using System;
using NetTopologySuite.Geometries;

namespace netcore_spatial.Data
{
    public class Place
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Point Point { get; set; }
    }
}