using MegamanXPasswordGenerator.source;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace MegamanXCodeGenerator.source
{
    public class PasswordGenerator
    {
        public PasswordGenerator(Factors currentFactors)
        {
            this.currentFactors = currentFactors;
        }

        //return code for each position
        public List<int> GeneratePasswordSlots()
        {
            var listOfSlots = new List<int>();
            var table = CriteriaFactory.CreateCriteriaTable();

            foreach(var a in table)
            {
                int slotValue;
                var evenFactors = IsEvenFactors(a.MainFactors);
                var hasX = TestXFactor(a.XFactors);
                var hasY = TestYFactor(a.YFactor);

                if(hasX && hasY) //si tiene ambos
                {
                    if (evenFactors) slotValue = a.XYCriteriaCode.First;
                    else             slotValue = a.XYCriteriaCode.Second;
                }
                else if(hasX)   //si tiene X
                {
                    if (evenFactors) slotValue = a.XCriteriaCode.First;
                    else             slotValue = a.XCriteriaCode.Second;
                }
                else if(hasY)  //si tiene Y
                {
                    if (evenFactors) slotValue = a.YCriteriaCode.First;
                    else             slotValue = a.YCriteriaCode.Second;
                }
                else           //si no tiene ninguno
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
            if (((CountFlags(currrentMainFactors) % 2) == 0) || currrentMainFactors.HasFlag(Factors.None))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TestXFactor(Factors factors)
        {
            return false;
        }

        private bool TestYFactor(Factors factors)
        {
            return false;
        }

        private int CountFlags(Factors factors)
        {
            return new BitArray(new[] { (int)factors }).OfType<bool>().Count(x => x);
        }

        private Factors currentFactors;
    }
}
