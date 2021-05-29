using EpidemieSimulator.Data;
using System;
using System.Collections.Generic;

namespace EpidemieSimulator.Services
{
    public class MapService
    {
        public readonly object Datalock = new ();
        public Dictionary<string, RegionData> BaseData
        {
            get => _baseData;
            set
            {
                lock (Datalock)
                {
                    _baseData = value;
                    MapUpdate.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private Dictionary<string, RegionData> _baseData;

        public void InvokeMapUpdate()
        {
            lock (Datalock)
            {
                MapUpdate.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler MapUpdate;
    }
}