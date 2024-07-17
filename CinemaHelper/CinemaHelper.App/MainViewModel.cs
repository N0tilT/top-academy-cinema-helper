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

        private string _input = string.Empty;
        public string Input
        {
            get => _input;
            set
            {
                _input = value;
                OnPropertyChanged("Input");
            }
        }

        private ObservableCollection<Cinema> _cinemaList = new ObservableCollection<Cinema>();
        public ObservableCollection<Cinema> CinemaList { get => _cinemaList; set { _cinemaList = value; OnPropertyChanged("CinemaList"); }  }

        private CinemaService cinemaService;

        private Cinema _selectedCinema;
        public Cinema SelectedCinema { get => _selectedCinema; 
            set { 
                _selectedCinema = value;
                OnPropertyChanged("SelectedCinema");
            } }

        public MainViewModel(CinemaService service)
        {
            cinemaService = service;
            CinemaList = new ObservableCollection<Cinema>(cinemaService.GetAll());
        }


        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      cinemaService.Create(
                          new Cinema(0, Input)
                          );
                      CinemaList = new ObservableCollection<Cinema>(cinemaService.GetAll());
                  }));
            }
        }

        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand(obj =>
                  {
                      cinemaService.Delete(
                          SelectedCinema.ItemId
                          );
                      CinemaList = new ObservableCollection<Cinema>(cinemaService.GetAll());
                  }));
            }
        }

        private RelayCommand editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand(obj =>
                  {
                      SelectedCinema.Title = Input;
                      cinemaService.Update(
                          SelectedCinema
                          );
                      CinemaList = new ObservableCollection<Cinema>(cinemaService.GetAll());
                  }));
            }
        }


    }
}
