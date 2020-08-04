using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using MegamanXCodeGenerator.source;
using MegamanXPasswordGenerator.source;

namespace MegamanXPasswordGenerator
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public String _test = "Hola";
        public List<String> _paths = new List<String>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Generate(object sender, RoutedEventArgs e)
        {
            var gen = new PasswordGenerator(m_Factors);
            var grid = new PasswordGrid(gen);
            m_paths = grid.GenerateGrid();
            m_test = "adios";
            Console.WriteLine(m_paths);
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
        public List<String> m_paths 
        {
            get { return _paths; }
            set { _paths = value; NotifyPropertyChanged(); }
        }

        public String m_test
        {
            get { return _test; }
            set
            {
                _test = value;
                NotifyPropertyChanged();
            }
        }

        private void CloseApplication(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeApplication(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Move(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
                Console.WriteLine("Me movere!");
                DragMove();
        }
    }

   

}
