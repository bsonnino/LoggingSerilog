using LoggingSerilog.ViewModel;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace LoggingSerilog.View
{
    public sealed partial class Log
    {
        public Log()
        {
            this.InitializeComponent();
            ViewModel = DataContext as LogViewModel;
        }

        public LogViewModel ViewModel { get; }
    }
}
