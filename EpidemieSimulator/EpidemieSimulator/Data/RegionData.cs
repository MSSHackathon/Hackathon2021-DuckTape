using System;
using System.Collections.Generic;

namespace EpidemieSimulator.Data
{
    public struct RegionData : IEquatable<RegionData>
    {
        public RegionData(string name, long pops = 10000000, bool port = false, bool air = false, bool border = false, bool train = false, bool quaratine = false, int medState = 5, List<RegionData> neighbours = null, bool runningPan = false)
        {
            Population = pops;
            HealthyPopulation = Population;
            CuredPopulation = 0;
            DeceasedPopulation = 0;
            InfectedPopulation = 0;
            HasAirTrafficAccess = air;
            HasLandBorder = border;
            HasPortAccess = port;
            HasTrainAccess = train;
            Quarantine = quaratine;
            MedicalEquipmentType = (MedicalEquipment)medState;
            Name = name;
            Neighbours = neighbours;
            runningPandemic = runningPan;
        }

        // Popluation-Data
        public long Population, HealthyPopulation, InfectedPopulation, DeceasedPopulation, CuredPopulation;

        // Connectivity Data -> regarding spread
        public bool HasPortAccess, HasAirTrafficAccess, HasTrainAccess, HasLandBorder;

        // Govermentmeasures
        public bool Quarantine; // Research actual measures taken .

        //
        public MedicalEquipment MedicalEquipmentType;

        //
        public string Name;

        public bool runningPandemic;

        public List<RegionData> Neighbours;

        /// <summary>
        /// Can later beused as a "multiplier" for infection/mortality rates
        /// </summary>
        public enum MedicalEquipment
        {
            Superb,
            AboveAverage,
            Average,
            BelowAverage,
            Bad
        }

        public bool Equals(RegionData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }

            // Optimization for a common success case.
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            // If run-time types are not exactly the same, return false.
            if (this.GetType() != other.GetType())
            {
                return false;
            }

            // Return true if the fields match.
            // Note that the base class is not invoked because it is
            // System.Object, which defines Equals as reference equality.
            return ( Population == other.Population) && (HealthyPopulation == other.HealthyPopulation) && (CuredPopulation == other.CuredPopulation) && (DeceasedPopulation == other.DeceasedPopulation) &&
                (InfectedPopulation == other.InfectedPopulation) && (HasAirTrafficAccess == other.HasAirTrafficAccess) && (HasLandBorder == other.HasLandBorder) && (HasPortAccess == other.HasPortAccess) &&
                (HasTrainAccess == other.HasTrainAccess) && (Quarantine == other.Quarantine) && (MedicalEquipmentType == other.MedicalEquipmentType) && (Name == other.Name) && (Neighbours == other.Neighbours) &&
                (runningPandemic == other.runningPandemic);
        }
    }
}