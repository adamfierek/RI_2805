using Models;
using Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string state = DateTime.Now.ToString();

        public Command TimerCommand { get; }

        private System.Timers.Timer timer;

        private IPersonServiceAsync personService;

        private bool isEnabled = true;
        public string State { get => state; set => Set(ref state, value); }
        public List<Person> PersonList { get; private set; }

        public MainWindowViewModel(IPersonServiceAsync _personService)
        {
            TimerCommand = new Command(_TimerCommand);

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            personService = _personService;
            Task.Run(LoadData);
        }

        private async Task LoadData()
        {
            PersonList = (await personService.GetAll()).ToList();
        }

        private async void _TimerCommand()
        {
            //if (isEnabled)
            //{
            //    timer?.Stop();
            //    isEnabled = false;
            //}
            //else
            //{
            //    timer?.Start();
            //    isEnabled = true;
            //}
            await LoadData();
            OnPropertyChanged(nameof(PersonList));
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            State = e.SignalTime.ToString();
        }
    }
}
