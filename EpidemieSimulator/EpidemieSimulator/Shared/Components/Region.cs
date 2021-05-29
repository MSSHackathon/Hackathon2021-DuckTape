using EpidemieSimulator.Data;
using Microsoft.AspNetCore.Components;

namespace EpidemieSimulator.Components
{
    public class Region
    {
        public RegionData Data;
        public ElementReference MapPart;
        public string Color = "#60D394";

        public Region(RegionData data, ElementReference element)
        {
            Data = data;
            MapPart = element;
        }
    }
}