using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Serilog.Events;

namespace LoggingSerilog
{
    public class LogStyleSelector : StyleSelector
    {
        public Style VerboseStyle { get; set; }
        public Style DebugStyle { get; set; }
        public Style InformationStyle { get; set; }
        public Style WarningStyle { get; set; }
        public Style ErrorStyle { get; set; }
        public Style FatalStyle { get; set; }
        protected override Style SelectStyleCore(object item, DependencyObject container)
        {
            var logEvent = item as LogEvent;
            if (logEvent == null)
                return null;

            switch (logEvent.Level)
            {
                case LogEventLevel.Verbose:
                    return VerboseStyle;
                case LogEventLevel.Debug:
                    return DebugStyle;
                case LogEventLevel.Information:
                    return InformationStyle;
                case LogEventLevel.Warning:
                    return WarningStyle;
                case LogEventLevel.Error:
                    return ErrorStyle;
                case LogEventLevel.Fatal:
                    return FatalStyle;
                default:
                    return null;
            }
        }
        
    }
}