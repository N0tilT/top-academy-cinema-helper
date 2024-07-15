using CinemaHelper.App.Core;
using CinemaHelper.Core;
using CinemaHelper.Core.Data;
using CinemaHelper.Core.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaHelper.App
{
    public class MainViewModel : ObservableObject
    {
        private ObservableCollection<Cinema> _cinemaList = new ObservableCollection<Cinema>();
        public ObservableCollection<Cinema> CinemaList { get => _cinemaList; set { _cinemaList = value; OnPropertyChanged("CinemaList"); }  }

        private CinemaService cinemaService;

        private Cinema _selectedCinema;
        public Cinema SelectedCinema { get => _selectedCinema; set { _selectedCinema = value; OnPropertyChanged("SelectedCinema"); } }

        public MainViewModel(CinemaService service)
        {
            cinemaService = service;
            CinemaList = new ObservableCollection<Cinema>(cinemaService.GetAll());
        }

        #region LeftSide
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


        #endregion

    }
}
