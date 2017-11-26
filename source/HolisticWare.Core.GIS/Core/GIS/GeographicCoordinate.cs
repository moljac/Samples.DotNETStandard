using System;

namespace Core.GIS
{
    public partial class GeographicCoordinate
    {
        public GeographicCoordinate()
        {
        }

        public GeographicCoordinate ToDegreesDecimal()
        {
            GeographicCoordinate gc = new GeographicCoordinate();


            return gc;
        }

        public GeographicCoordinate ToDD()
        {
            return this.ToDegreesDecimal();
        }

        public GeographicCoordinate ToDegreesMinutesSeconds()
        {
            GeographicCoordinate gc = new GeographicCoordinate();


            return gc;
        }
    }
}
