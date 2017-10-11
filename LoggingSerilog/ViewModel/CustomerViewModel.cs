using GalaSoft.MvvmLight;
using LoggingSerilog.Model;
using Serilog;

namespace LoggingSerilog.ViewModel
{
    public class CustomerViewModel : ViewModelBase
    {
        private readonly Customer _customer;

        public CustomerViewModel(Customer customer)
        {
            _customer = customer;
        }

        public string Id
        {
            get => _customer.Id;
            set
            {
                Log.Verbose("Customer Id changed from {OldId} to {NewId}", _customer.Id,value);
                _customer.Id = value;
                RaisePropertyChanged();
            }
        }

        public string Name {
            get => _customer.Name;
            set
            {
                Log.Verbose("Customer Name changed from {OldName} to {NewName}", _customer.Name, value);
                _customer.Name = value;
                RaisePropertyChanged();
            }
        }

        public string Address
        {
            get => _customer.Address;
            set
            {
                Log.Verbose("Customer Address changed from {OldAddress} to {NewAddress}", _customer.Address, value);
                _customer.Address = value;
                RaisePropertyChanged();
            }
        }

        public string City
        {
            get => _customer.City;
            set
            {
                Log.Verbose("Customer City changed from {OldCity} to {NewCity}", _customer.City, value);
                _customer.City = value;
                RaisePropertyChanged();
            }
        }

        public string Country
        {
            get => _customer.Country;
            set
            {
                Log.Verbose("Customer Country changed from {OldCountry} to {NewCountry}", _customer.Country, value);
                _customer.Country = value;
                RaisePropertyChanged();
            }
        }

        public string Phone
        {
            get => _customer.Phone;
            set
            {
                Log.Verbose("Customer Phone changed from {OldPhone} to {NewPhone}", _customer.Phone, value);
                _customer.Phone = value;
                RaisePropertyChanged();
            }
        }
    }
}
