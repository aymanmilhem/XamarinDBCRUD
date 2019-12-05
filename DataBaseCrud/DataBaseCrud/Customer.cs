using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using DataBaseCrud.Annotations;
using SQLite;

namespace DataBaseCrud
{
    [Table("Customers")]
    public class Customer : INotifyPropertyChanged
    {
        private int _id;

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get => _id;
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _companyName;
        [SQLite.NotNull]
        public string CompanyName
        {
            get => _companyName;
            set
            {
                this._companyName = value;
                OnPropertyChanged(nameof(CompanyName));
            }
        }

        private string _physicalAddress;

        [MaxLength(50)]
        public string PhysicalAddress
        {
            get => _physicalAddress;
            set
            {
                this._physicalAddress = value;
                OnPropertyChanged(nameof(_physicalAddress));
            }
        }

        private string _country;
        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
