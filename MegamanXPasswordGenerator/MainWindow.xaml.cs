using MegamanXPasswordGenerator.source;
using System;
using System.Collections;
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
    

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestFlags();
        }

        public void TestFlags()
        {
            CriteriaFactory factory = new CriteriaFactory();
            var table = factory.CreateCriteriaTable();
        }

        public static int CountFlags(Factors factors)
        {
            return new BitArray(new[] { (int)factors }).OfType<bool>().Count(x => x);
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


    public class CreatePasswordSlot
    {
        
    }
}
