using CinemaHelper.App.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaHelper.App
{
    public class MainViewModel : ObservableObject
    {
        private string _input = string.Empty;
        public string Input {
            get => _input; 
            set { 
                _input = value; 
                OnPropertyChanged("Input");
            } 
        }

        private string _output = string.Empty;
        public string Output
        {
            get => _output;
            set
            {
                _output = value;
                OnPropertyChanged("Output");
            }
        }

        private RelayCommand showCommand;
        public RelayCommand ShowCommand
        {
            get
            {
                return showCommand ??
                  (showCommand = new RelayCommand(obj =>
                  {
                      Output = Input;
                  }));
            }
        }

        private RelayCommand clearCommand;
        public RelayCommand ClearCommand
        {
            get
            {
                return clearCommand ??
                  (clearCommand = new RelayCommand(obj =>
                  {
                      Output = string.Empty;
                      Input = string.Empty;
                  }));
            }
        }

    }
}
