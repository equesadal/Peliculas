using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace Peliculas.Data.Geometry
{
    public static class GeometryFactoryHelper
    {
        public static GeometryFactory GeometryFactory { get; set; }
            = NtsGeometryServices.Instance.CreateGeometryFactory(4326);
    }
}
