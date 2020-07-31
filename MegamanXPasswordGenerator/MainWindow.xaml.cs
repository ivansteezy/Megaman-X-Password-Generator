using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegamanXPasswordGenerator
{
    [Flags]
    public enum MainFactors
    {
        ChillPenguin                = 0x000001,
        ChillPenguinHeartTank       = 0x000002,
        ChillPenguinEtank           = 0x000004,
        ArmourLeg                   = 0x000008,
        SparkMandrill               = 0x000010,
        SparkMandrillHeartTank      = 0x000020,
        ArmoredArmadillo            = 0x000040,
        ArmoredArmadilloEtank       = 0x000080,
        ArmoredArmadilloHeartTank   = 0x000100,
        LaunchOctopus               = 0x000200,
        LaunchOctopusHeartTank      = 0x000400,
        BoomerKuwanger              = 0x000800,
        BoomerKuwangerHeartTank     = 0x001000,
        StingChameleon              = 0x002000,
        StingChameleonHeartTank     = 0x004000,
        BodyArmour                  = 0x008000,
        StormEagle                  = 0x010000,
        StormEagleHeartTank         = 0x020000,
        StormEagleEtank             = 0x040000,
        HeadArmour                  = 0x080000,
        FlameMammoth                = 0x100000,
        FlameMammothHeartTank       = 0x200000,
        FlameMammothEtank           = 0x400000,
        ChargeArmour                = 0x800000,
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //FeedData();
            TestFlags();
        }

        public void TestFlags()
        {
            var factors = MegamanXPasswordGenerator.MainFactors.ArmoredArmadillo | MegamanXPasswordGenerator.MainFactors.ArmoredArmadilloEtank;

            if (factors.HasFlag(MegamanXPasswordGenerator.MainFactors.ArmoredArmadillo))
                Console.WriteLine("Has derrotado a armored armadillo");
            else
                Console.WriteLine("Has derrotado a armored armadillo");
        }

        public List<CheckBox> FeedData()
        {
            List<CheckBox> collection = new List<CheckBox>();
            collection.Add(armadilloIsDefeated);
            collection.Add(armadilloEtank);
            collection.Add(armadilloHeartTank);
            collection.Add(octopusIsDefeated);
            collection.Add(octopusHeartTank);
            collection.Add(penguinIsDefeated);
            collection.Add(penguinHeartTank);
            collection.Add(pantsArmour);
            collection.Add(mammothIsDefeated);
            collection.Add(mammothHeartTank);
            collection.Add(mammothEtank);
            collection.Add(chargeArmour);
            collection.Add(eagleIsDefeated);
            collection.Add(eagleHeartTank);
            collection.Add(eagleETank);
            collection.Add(mandrillIsDefeated);
            collection.Add(mandrillHeartTank);
            collection.Add(chameleonIsDefeated);
            collection.Add(chameleonHeartTank);
            collection.Add(chameleonBodyArmour);
            collection.Add(boomerDefeated);
            collection.Add(boomerHeartTank);

            return collection;
        }
    }

    public class Pair<T, U>
    {
        public Pair() { }

        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        public T First  { get; set; }
        public U Second { get; set; }
    }

    public class PasswordSlot
    {
        PasswordSlot()
        {

        }

        public Pair<int, int> Position { get; set; }
        public Pair<int, int> N        { get; set; }
        public Pair<int, int> X        { get; set; }
        public Pair<int, int> Y        { get; set; }
        public Pair<int, int> XY       { get; set; }
    }
}
