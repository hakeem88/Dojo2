using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Shared.BaseModels;
using Shared.Interfaces;
using Shared.Models;
using Simulation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace Dojo2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string currentTime = DateTime.Now.ToLocalTime().ToShortTimeString();

        public String CurrentDate
        {
            get { return CurrentDate; }
            set { CurrentDate = value; RaisePropertyChanged(); }
        }

        public String CurrentTime
        {
            get { return CurrentTime; }
            set { CurrentTime = value; RaisePropertyChanged(); }
        }
    }
}
