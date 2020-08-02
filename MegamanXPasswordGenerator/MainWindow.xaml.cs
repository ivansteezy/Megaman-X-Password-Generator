using System;
using System.Windows;
using System.Windows.Controls;
using MegamanXCodeGenerator.source;
using MegamanXPasswordGenerator.source;

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
            Console.WriteLine(m_Factors.ToString());
            var gen = new PasswordGenerator(m_Factors);
            var passwordGrid = gen.GeneratePasswordSlots();
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
