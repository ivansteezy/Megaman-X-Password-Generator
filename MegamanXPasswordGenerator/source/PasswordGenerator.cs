using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using MegamanXPasswordGenerator.source;

namespace MegamanXCodeGenerator.source
{
    public class PasswordGenerator
    {
        public PasswordGenerator(Factors currentFactors)
        {
            this.currentFactors = currentFactors;
        }

        public List<int> GeneratePasswordSlots()
        {
            var factory = new CriteriaFactory();
            var listOfSlots = new List<int>();
            var table = factory.CreateCriteriaTable();

            foreach(var a in table)
            {
                int slotValue;
                var evenFactors = IsEvenFactors(a.MainFactors);
                var hasX = currentFactors.HasFlag(a.XFactors);
                var hasY = currentFactors.HasFlag(a.YFactors);

                if(hasX && hasY)
                {
                    if (evenFactors) slotValue = a.XYCriteriaCode.First;
                    else             slotValue = a.XYCriteriaCode.Second;
                }
                else if(hasX)
                {
                    if (evenFactors) slotValue = a.XCriteriaCode.First;
                    else             slotValue = a.XCriteriaCode.Second;
                }
                else if(hasY)
                {
                    if (evenFactors) slotValue = a.YCriteriaCode.First;
                    else             slotValue = a.YCriteriaCode.Second;
                }
                else
                {
                    if (evenFactors) slotValue = a.NCriteriaCode.First;
                    else             slotValue = a.NCriteriaCode.Second;
                }
                Console.Write("En la posicion (" + a.Position.First + ", " + a.Position.Second + ")" + "hay un: " + slotValue + "\n");
                listOfSlots.Add(slotValue);
            }

            return listOfSlots;
        }

        private bool IsEvenFactors(Factors currrentMainFactors)
        {
            var submask = currrentMainFactors & this.currentFactors;
            if (((CountFlags(submask) % 2) == 0) || submask.HasFlag(Factors.None)) return true;
            else                                                                   return false;
        }

        private int CountFlags(Factors factors)
        {
            return new BitArray(new[] { (int)factors }).OfType<bool>().Count(x => x);
        }

        private Factors currentFactors;
    }
}
