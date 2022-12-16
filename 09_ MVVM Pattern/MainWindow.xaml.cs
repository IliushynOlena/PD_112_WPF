using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace _09__MVVM_Pattern
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
          
            dialog.IsFolderPicker = true;
            CommonFileDialogResult res =  dialog.ShowDialog();
            if(res == CommonFileDialogResult.Ok)
            {
                viewModel.LoadFiles(dialog.FileName);
            }

        }
    }
}
