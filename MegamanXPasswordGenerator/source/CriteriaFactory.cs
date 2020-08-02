using System;
using System.Linq;
using System.Collections.Generic;

namespace MegamanXPasswordGenerator.source
{
    [Flags]
    public enum Factors
    {
        ChillPenguin               = 0x0000001,
        ChillPenguinHeartTank      = 0x0000002,
        Boots                      = 0x0000004,
        SparkMandrill              = 0x0000008,
        SparkMandrillHeartTank     = 0x0000010,
        SparkMandrillSubTank       = 0x0000020,
        ArmoredArmadillo           = 0x0000040,
        ArmoredArmadilloSubTank    = 0x0000080,
        ArmoredArmadilloHeartTank  = 0x0000100,
        LaunchOctopus              = 0x0000200,
        LaunchOctopusHeartTank     = 0x0000400,
        BoomerKuwanger             = 0x0000800,
        BoomerKuwangerHeartTank    = 0x0001000,
        StingChameleon             = 0x0002000,
        StingChameleonHeartTank    = 0x0004000,
        Armor                      = 0x0008000,
        StormEagle                 = 0x0010000,
        StormEagleHeartTank        = 0x0020000,
        StormEagleSubTank          = 0x0040000,
        Helmet                     = 0x0080000,
        FlameMammoth               = 0x0100000,
        FlameMammothHeartTank      = 0x0200000,
        FlameMammothSubTank        = 0x0400000,
        MegaBuster                 = 0x0800000,
        None                       = 0x1000000
    }

    public class CriteriaFactory
    {
        public List<Criteria> CreateCriteriaTable()
        {
            var criteriaList = new List<Criteria>();

            for (var i = 0; i < 12; i++)
            {
                var criteria = new Criteria();
                criteria.Position       = Positions.ElementAt(i);
                criteria.NCriteriaCode  = NPositionCode.ElementAt(i);
                criteria.XCriteriaCode  = XPositionCode.ElementAt(i);
                criteria.YCriteriaCode  = YPositionCode.ElementAt(i);
                criteria.XYCriteriaCode = XYPositionCode.ElementAt(i);
                criteria.XFactors       = XFactors.ElementAt(i);
                criteria.YFactors        = YFactors.ElementAt(i);
                criteria.MainFactors    = MainFactors.ElementAt(i);

                criteriaList.Add(criteria);
            }

            return criteriaList;
        }

        static IEnumerable<Pair<int, int>> Positions = new List<Pair<int, int>>()
        {
            new Pair<int, int>(1, 1), new Pair<int, int>(2, 1), new Pair<int, int>(3, 1), new Pair<int, int>(4, 1),
            new Pair<int, int>(1, 2), new Pair<int, int>(2, 2), new Pair<int, int>(3, 2), new Pair<int, int>(4, 2),
            new Pair<int, int>(1, 3), new Pair<int, int>(2, 3), new Pair<int, int>(3, 3), new Pair<int, int>(4, 3),
        };

        static IEnumerable<Pair<int, int>> NPositionCode = new List<Pair<int, int>>()
        {
            new Pair<int, int>(1, 8), new Pair<int, int>(8, 8), new Pair<int, int>(2, 6), new Pair<int, int>(1, 1),
            new Pair<int, int>(5, 7), new Pair<int, int>(8, 2), new Pair<int, int>(5, 4), new Pair<int, int>(2, 2),
            new Pair<int, int>(4, 1), new Pair<int, int>(3, 2), new Pair<int, int>(2, 2), new Pair<int, int>(5, 5),
        };

        static IEnumerable<Pair<int, int>> XPositionCode = new List<Pair<int, int>>()
        {
            new Pair<int, int>(4, 6), new Pair<int, int>(3, 3), new Pair<int, int>(8, 7), new Pair<int, int>(4, 4),
            new Pair<int, int>(3, 2), new Pair<int, int>(4, 7), new Pair<int, int>(8, 1), new Pair<int, int>(6, 6),
            new Pair<int, int>(2, 7), new Pair<int, int>(7, 8), new Pair<int, int>(4, 4), new Pair<int, int>(3, 3),
        };

        static IEnumerable<Pair<int, int>> YPositionCode = new List<Pair<int, int>>()
        {
            new Pair<int, int>(3, 7), new Pair<int, int>(2, 2), new Pair<int, int>(5, 3), new Pair<int, int>(6, 6),
            new Pair<int, int>(1, 8), new Pair<int, int>(1, 3), new Pair<int, int>(3, 7), new Pair<int, int>(8, 8),
            new Pair<int, int>(6, 5), new Pair<int, int>(4, 1), new Pair<int, int>(6, 6), new Pair<int, int>(2, 2),
        };

        static IEnumerable<Pair<int, int>> XYPositionCode = new List<Pair<int, int>>()
        {
            new Pair<int, int>(2, 5), new Pair<int, int>(1, 1), new Pair<int, int>(4, 1), new Pair<int, int>(8, 8),
            new Pair<int, int>(6, 4), new Pair<int, int>(6, 5), new Pair<int, int>(6, 2), new Pair<int, int>(7, 7),
            new Pair<int, int>(8, 3), new Pair<int, int>(6, 5), new Pair<int, int>(7, 7), new Pair<int, int>(6, 6),
        };

        static IEnumerable<Factors> XFactors = new List<Factors>()
        {
            Factors.ArmoredArmadilloHeartTank, Factors.StingChameleon, Factors.LaunchOctopusHeartTank, Factors.ChillPenguin,
            Factors.LaunchOctopus,             Factors.BoomerKuwanger, Factors.ArmoredArmadillo,       Factors.SparkMandrill,
            Factors.ChillPenguinHeartTank,     Factors.FlameMammoth,   Factors.FlameMammothHeartTank,  Factors.StormEagle,

        };

        static IEnumerable<Factors> YFactors = new List<Factors>()
        {
            Factors.Boots,                   Factors.StormEagleSubTank,        Factors.SparkMandrillSubTank, Factors.SparkMandrillHeartTank,
            Factors.Armor,                   Factors.BoomerKuwangerHeartTank,  Factors.MegaBuster,           Factors.StingChameleonHeartTank,
            Factors.ArmoredArmadilloSubTank, Factors.Helmet,                   Factors.FlameMammothSubTank,  Factors.StormEagleHeartTank,
        };

        static IEnumerable<Factors> MainFactors = new List<Factors>()
        {
            //(1, 1)
            ( Factors.ArmoredArmadillo        | Factors.BoomerKuwanger         | Factors.BoomerKuwangerHeartTank
            | Factors.ChillPenguinHeartTank   | Factors.FlameMammothHeartTank  | Factors.LaunchOctopusHeartTank
            | Factors.StingChameleonHeartTank | Factors.SparkMandrillSubTank   | Factors.Armor),

            //(2, 1)
            (Factors.None),

            //(3, 1)
            (Factors.ArmoredArmadillo | Factors.BoomerKuwanger | Factors.ChillPenguin   | Factors.FlameMammoth |
             Factors.LaunchOctopus    | Factors.SparkMandrill  | Factors.StingChameleon | Factors.StormEagle),

            //(4, 1)
            Factors.None,

            //(1, 2)
            ( Factors.ArmoredArmadillo | Factors.BoomerKuwanger | Factors.ChillPenguin | Factors.FlameMammoth
            | Factors.StormEagle | Factors.ArmoredArmadilloHeartTank | Factors.BoomerKuwangerHeartTank
            | Factors.ArmoredArmadilloSubTank | Factors.MegaBuster),

            //(2, 2)
            ( Factors.ArmoredArmadilloSubTank | Factors.FlameMammothSubTank | Factors.SparkMandrillSubTank
            | Factors.StormEagleSubTank | Factors.Boots | Factors.Helmet | Factors.Armor | Factors.MegaBuster),

            //(3, 2)
            ( Factors.LaunchOctopus | Factors.StormEagle | Factors.ChillPenguinHeartTank | Factors.FlameMammothHeartTank
            | Factors.StormEagleSubTank | Factors.Helmet),

            //(4, 2)
            Factors.StingChameleonHeartTank,

            //(1, 3)
            ( Factors.ChillPenguin | Factors.FlameMammoth | Factors.LaunchOctopusHeartTank | Factors.StingChameleonHeartTank
            | Factors.SparkMandrillSubTank | Factors.StormEagleSubTank | Factors.Helmet | Factors.Armor | Factors.MegaBuster),

            //(2, 3)
            ( Factors.ArmoredArmadilloHeartTank | Factors.BoomerKuwangerHeartTank | Factors.ChillPenguinHeartTank
            | Factors.FlameMammothHeartTank | Factors.LaunchOctopusHeartTank | Factors.SparkMandrillHeartTank
            | Factors.StingChameleonHeartTank | Factors.StormEagleHeartTank),

            //(3, 3)
            Factors.None,

            //(4, 3)
            Factors.None
        };
    }
}
