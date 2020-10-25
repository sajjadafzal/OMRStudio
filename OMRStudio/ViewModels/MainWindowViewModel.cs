using OMRStudio.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Input;

namespace OMRStudio.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public RelayCommands<string> NavCommand { get; set; }        
        public MainWindowViewModel()
        {
            NavCommand = new RelayCommands<string>(OnNav);
            CurrentViewModel = imageViewModel;
        }

        private BaseViewModel _CurrentViewModel;
        private DataViewModel dataViewModel = new DataViewModel();
        private ImageViewModel imageViewModel = new ImageViewModel();
        public BaseViewModel CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }
        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "imageview":
                    CurrentViewModel = imageViewModel;
                    break;
                case "dataview":
                    CurrentViewModel = dataViewModel;
                    break;
                default:
                    CurrentViewModel = imageViewModel;
                    break;
            }
        }

    }
}
