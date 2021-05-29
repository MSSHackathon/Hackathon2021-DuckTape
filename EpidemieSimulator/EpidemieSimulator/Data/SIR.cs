using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EpidemieSimulator.Data
{
    public class SIR
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="N">Total Population</param>
        /// <param name="S">Susceptible Population</param>
        /// <param name="I">Currently infected</param>
        /// <param name="R">died/recovered/immune</param>
        /// <param name="t">time</param>
        /// <param name="b">infection rate</param>
        /// <param name="a">remove rate</param>
        /// <param name="scale"></param>

        public measure HygieneMeasures = new measure();
        public measure MandatoryMasks = new measure();
        public measure MinimumDistance = new measure();
        public measure TravelBan = new measure();
        public measure Homeoffice = new measure();
        public measure ExitBarrier = new measure();
        public List<measure> Measures = new List<measure>();

        private void CreateMeasures()
        {
            HygieneMeasures.name = "Hygienemaßnahmen";
            HygieneMeasures.used = false;
            HygieneMeasures.value = 0.04;
            Measures.Add(HygieneMeasures);

            MandatoryMasks.name = "Maskenpflicht";
            MandatoryMasks.used = false;
            MandatoryMasks.value = 0.02;
            Measures.Add(MandatoryMasks);

            MinimumDistance.name = "Mindestabstand";
            MinimumDistance.used = false;
            MinimumDistance.value = 0.06;
            Measures.Add(MinimumDistance);

            TravelBan.name = "Reiseverbot";
            TravelBan.used = false;
            TravelBan.value = 0.06;
            Measures.Add(TravelBan);

            Homeoffice.name = "Homeoffice";
            Homeoffice.used = false;
            Homeoffice.value = 0.04;
            Measures.Add(Homeoffice);

            ExitBarrier.name = "Ausgangssperre";
            ExitBarrier.used = true;
            ExitBarrier.value = 0.03;
            Measures.Add(ExitBarrier);
        }

        public double[,] calc(double N = 10000.0,
                    double S = 9000.0,
                    double I = 1000.0,
                    double R = 0.0,
                    double t = 0,
                    double b = 2.0,
                    double a = 0.5,
                    double scale = 0.1)
        {
            if (Measures.Count == 0)
            {
                CreateMeasures();
            }

            foreach (var item in Measures)
            {
                if (item.used == true && b > 0)
                {
                    b -= item.value;
                }
            }

            double[,] erg = new double[4, 100];
            for (int i = 0; i < 100; ++i)
            {
                erg[0, i] = t;
                erg[1, i] = S;
                erg[2, i] = I;
                erg[3, i] = R;
                double dS = (-b * S * I) / N;
                double dI = ((b * S * I) / N) - a * I;
                double dR = a * I;
                double dT = 1;

                S = S + dS * scale;
                I = I + dI * scale;
                R = R + dR * scale;
                t = t + dT * scale;
            }
            return erg;
        }

        //public async IAsyncEnumerable<double> yieldCalcI(
        //            double N = 10000.0,
        //            double S = 9000.0,
        //            double I = 1000.0,
        //            double R = 0.0,
        //            double t = 0,
        //            double b = 2.0,
        //            double a = 0.5,
        //            double scale = 0.1)
        //{
        //    if (Measures.Count == 0)
        //    {
        //        CreateMeasures();
        //    }

        //    foreach (var item in Measures)
        //    {
        //        if (item.used == true && b > 0)
        //        {
        //            b -= item.value;
        //        }
        //    }
        //    int i = 0;

        //    while (i < 100)
        //    {
        //        double dS = (-b * S * I) / N;
        //        double dI = ((b * S * I) / N) - a * I;
        //        double dR = a * I;
        //        double dT = 1;

        //        S = S + dS * scale;
        //        I = I + dI * scale;
        //        R = R + dR * scale;
        //        t = t + dT * scale;
        //        i++;
        //        await Task.Delay(100);
        //        yield return I;
        //    }
        //}

        //public async IAsyncEnumerable<double> yieldCalcS(
        //            double N = 10000.0,
        //            double S = 9000.0,
        //            double I = 1000.0,
        //            double R = 0.0,
        //            double t = 0,
        //            double b = 2.0,
        //            double a = 0.5,
        //            double scale = 0.1)
        //{
        //    if (Measures.Count == 0)
        //    {
        //        CreateMeasures();
        //    }

        //    foreach (var item in Measures)
        //    {
        //        if (item.used == true && b > 0)
        //        {
        //            b -= item.value;
        //        }
        //    }
        //    int i = 0;

        //    while (i < 100)
        //    {
        //        double dS = (-b * S * I) / N;
        //        double dI = ((b * S * I) / N) - a * I;
        //        double dR = a * I;
        //        double dT = 1;

        //        S = S + dS * scale;
        //        I = I + dI * scale;
        //        R = R + dR * scale;
        //        t = t + dT * scale;
        //        i++;
        //        await Task.Delay(100);
        //        yield return S;
        //    }
        //}

        //public async IAsyncEnumerable<double> yieldCalcR(
        //    double N = 10000.0,
        //    double S = 9000.0,
        //    double I = 1000.0,
        //    double R = 0.0,
        //    double t = 0,
        //    double b = 2.0,
        //    double a = 0.5,
        //    double scale = 0.1)
        //{
        //    if (Measures.Count == 0)
        //    {
        //        CreateMeasures();
        //    }

        //    foreach (var item in Measures)
        //    {
        //        if (item.used == true && b > 0)
        //        {
        //            b -= item.value;
        //        }
        //    }
        //    int i = 0;

        //    while (i < 100)
        //    {
        //        double dS = (-b * S * I) / N;
        //        double dI = ((b * S * I) / N) - a * I;
        //        double dR = a * I;
        //        double dT = 1;

        //        S = S + dS * scale;
        //        I = I + dI * scale;
        //        R = R + dR * scale;
        //        t = t + dT * scale;
        //        i++;
        //        await Task.Delay(100);
        //        yield return R;
        //    }
        //}

        public async IAsyncEnumerable<(double S, double I, double R)> yieldCalcEverything(
            double N = 10000.0,
            double S = 9000.0,
            double I = 1000.0,
            double R = 0.0,
            double t = 0,
            double b = 2.0,
            double a = 0.5,
            double scale = 0.1)
        {
            if (Measures.Count == 0)
            {
                CreateMeasures();
            }

            foreach (var item in Measures)
            {
                if (item.used == true && b > 0)
                {
                    b -= item.value;
                }
            }

            do
            {
                double dS = (-b * S * I) / N;
                double dI = ((b * S * I) / N) - a * I;
                double dR = a * I;
                double dT = 1;

                S = S + dS * scale;
                I = I + dI * scale;
                R = R + dR * scale;
                t = t + dT * scale;
                await Task.Delay(100);
                yield return (S, I, R);
            } while (Math.Round(I) != 0);
        }
    }
}