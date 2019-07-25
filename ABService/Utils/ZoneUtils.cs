using System;
using System.Collections.Generic;
using System.Text;

namespace ABGCP.Utils
{
    public enum Reigons
    {
        // Changhua County, Taiwan
        ASIA_EAST1,

        // Hong Kong
        ASIA_EAST2,

        // Tokyo, Japan
        ASIA_NORTHEAST1,

        // Osaka, Japan
        ASIA_NORTHEAST2,

        // Mumbai, India
        ASIA_SOUTH1,

        // Jurong West, Singapore
        ASIA_SOUTHEAST1,

        // Sydney, Australia
        AUSTRALIA_SOUTHEAST1,

        // Hamina, Finland
        EUROPE_NORTH1,

        // St. Ghislain, Belgium
        EUROPE_WEST1,

        // London, England, UK
        EUROPE_WEST2,

        // Frankfurt, Germany
        EUROPE_WEST3,

        // Eemshaven, Netherlands
        EUROPE_WEST4,

        // Zürich, Switzerland
        EUROPE_WEST6,

        // Montréal, Québec, Canada
        NORTHAMERICA_NORTHEAST1,

        // São Paulo, Brazil
        SOUTHAMERICA_EAST1,

        // Council Bluffs, Iowa, USA
        US_CENTRAL1,

        // 	Moncks Corner, South Carolina, USA
        US_EAST1,

        // Ashburn, Northern Virginia, USA
        US_EAST4,

        // The Dalles, Oregon, USA
        US_WEST1,

        // Los Angeles, California, USA
        US_WEST2,
    }

    public enum Zones
    {
        A, B, C, D, F
    }

    public class ZoneUtils
    {
        static public string FormatZone(Reigons reigon, Zones zone)
        {
            string strZone = "";

            foreach (char c in reigon.ToString())
            {
                strZone += c != '_' ? char.ToLower(c) : '-';
            }

            strZone += '-';
            strZone += char.ToLower(zone.ToString()[0]);

            return strZone;
        }
    }
}
