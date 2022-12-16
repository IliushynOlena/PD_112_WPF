using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09__MVVM_Pattern
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private string directoryPath;
        ObservableCollection<FileInfo> files = new ObservableCollection<FileInfo>();

        public event PropertyChangedEventHandler? PropertyChanged;

        public IEnumerable<FileInfo> Files => files;
        private FileInfo selectedFile;

        public FileInfo SelectedFile
        {
            get { return selectedFile; }
            set 
            { selectedFile = value;
                OnPropertyChanged();
            }
        }
       
        public string DirectoryPath {

            get => this.directoryPath;
            set 
            {
                this.directoryPath = value;
               
                //OnPropertyChanged(nameof(DirectoryName));
            }
        }
        public string? DirectoryName => Path.GetFileName(DirectoryPath);
        public ViewModel()
        {
            LoadFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void LoadFiles(string dirPath)
        {
            this.DirectoryPath = dirPath;
            DirectoryInfo directory = new DirectoryInfo(dirPath);
            var data = directory.GetFiles();
            files.Clear();
            foreach (var item in data)
            {
                files.Add(item);
            }
           // files = new ObservableCollection<FileInfo>(data);
        }
    }
}
