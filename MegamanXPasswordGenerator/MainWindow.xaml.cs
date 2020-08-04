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
using System.Windows.Media;
using MegamanXCodeGenerator.source;
using MegamanXPasswordGenerator.source;

namespace MegamanXPasswordGenerator
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public List<String> paths = new List<String>();
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
        public List<String> m_paths 
        {
            get { return paths; }
            set { paths = value; NotifyPropertyChanged(); }
        }

        private void CloseApplication(object sender, System.Windows.Input.MouseButtonEventArgs e) { Application.Current.Shutdown(); }

        private void MinimizeApplication(object sender, System.Windows.Input.MouseButtonEventArgs e) { WindowState = WindowState.Minimized; }

        private void Move(object sender, System.Windows.Input.MouseButtonEventArgs e) { DragMove(); }
    }
}
