using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using GalaSoft.MvvmLight;
using Serilog;
using Serilog.Events;

namespace LoggingSerilog.ViewModel
{
    public class LogViewModel : ViewModelBase
    {
        public LogViewModel()
        {
            LogItems = new ObservableCollection<LogEvent>();
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Observers(events => events
                    .Do(evt => LogItems.Add(evt))
                    .Subscribe())
                .CreateLogger();
        }
        public ObservableCollection<LogEvent> LogItems { get; }
    }
}
