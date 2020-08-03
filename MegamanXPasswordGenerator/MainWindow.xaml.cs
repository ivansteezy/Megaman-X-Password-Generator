using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices.ComTypes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
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
            var gen = new PasswordGenerator(m_Factors);
            var grid = new PasswordGrid(gen);
            m_paths = grid.GenerateGrid();
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

        public Factors m_Factors  { get; set; }
        public ObservableCollection<String> m_paths { get; set; }
    }

   

}
