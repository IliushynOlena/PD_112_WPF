using System;
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

namespace _10_ColorViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
    class ViewModel :INotifyPropertyChanged
    {

        private byte a;
        private byte r;
        private byte g;
        private byte b;
        public byte A
        {
            get { return a; }
            set { a = value; OnPropertyChanged(); OnPropertyChanged(nameof(Color)); }
        }    

        public byte R
        {
            get { return r; }
            set { r = value; OnPropertyChanged(); OnPropertyChanged(nameof(Color)); }
        }       

        public byte G
        {
            get { return g; }
            set { g = value; OnPropertyChanged(); OnPropertyChanged(nameof(Color)); }
        }
        public byte B
        {
            get { return b; }
            set { b = value; OnPropertyChanged(); OnPropertyChanged(nameof(Color)); }
        }

        public Color Color { get { return Color.FromArgb(A, R, G, B); } }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ViewModel()
        {
            //a = r = g = b = 0;
        }
     
    }
}
