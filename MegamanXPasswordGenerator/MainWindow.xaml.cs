using MegamanXCodeGenerator.source;
using MegamanXPasswordGenerator.source;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
        }

        private void Generate(object sender, RoutedEventArgs e)
        {
            var gen = new PasswordGenerator(m_Factors);
            gen.GeneratePasswordSlots();
        }

        private void Checked(object sender, RoutedEventArgs e)
        {
            var chboxName = ((CheckBox)sender).Name;
            m_Factors |= (Factors)Enum.Parse(typeof(Factors), chboxName);
        }

        private void Unchecked(object sender, RoutedEventArgs e)
        {
            var chboxName = ((CheckBox)sender).Name;
            m_Factors &= ~(Factors)Enum.Parse(typeof(Factors), chboxName);
        }

        public Factors m_Factors { get; set; }
    }

   

}
