using OMRStudio.Interfaces;
using OMRStudio.Models;
using OMRStudio.Services;
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
        ProjectModel project;
        public RelayCommands<string> NavCommand { get; set; } 
        public RelayCommands NewProjectCommand { get; set; }
        public MainWindowViewModel()
        {
            project = Factory.CreateNew<ProjectModel>();
            NavCommand = new RelayCommands<string>(OnNav);
            NewProjectCommand = new RelayCommands(OnNewProject);
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

        private void OnNewProject()
        {
            IFolderBrowser browser = Factory.CreateNew<BrowserServices>();
            project.ProjectDirectoryPath = browser.BrowseFolder();
        }

    }
}
