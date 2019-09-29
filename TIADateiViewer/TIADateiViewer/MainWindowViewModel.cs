using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TIADateiViewer
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object>(ShowMessage));
        }

        private ICommand m_ButtonCommand;
        public ICommand ButtonCommand
        {
            get
            {
                return m_ButtonCommand;
            }
            set
            {
                m_ButtonCommand = value;
            }
        }

        public void ShowMessage(object obj)
        {
            XMLDeserializer x = new XMLDeserializer();

            string xmlInputData = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                x.TestDeserialize(openFileDialog.FileName);
        }

        //public List<Department> Departments
        //{
        //    get
        //    {
        //        return departments;
        //    }
        //    set
        //    {
        //        departments = value;
        //        OnPropertyChanged("Departments");
        //    }
        //}
    }
}
