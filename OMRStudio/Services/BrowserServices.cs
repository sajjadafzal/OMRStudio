using OMRStudio.Interfaces;
using OMRStudio.Models;
using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace OMRStudio.Services
{
    public class BrowserServices : IFolderBrowser
    {
        public string BrowseFolder()
        {

            VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select a folder.";
            dialog.UseDescriptionForTitle = true;
            if ((bool)dialog.ShowDialog())
            {
                return dialog.SelectedPath;
            }
            else 
            {
                return "";
            }
        }
    }
}
