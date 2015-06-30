using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MVVM.Annotations;

namespace MVVM.Models
{
    public class Person :INotifyPropertyChanged, IDataErrorInfo
    {

        public int Id { get; set; }

        private string _firstname;

        public string Firstname
        {
            get { return _firstname;  }
            set
            {
                _firstname = value;
                OnPropertyChanged("Firstname");
            }
        }

        private string _lastname;

        public string Lastname
        {
            get { return _lastname;  }
            set
            {
                _lastname = value;
                OnPropertyChanged("Lastname");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;

                if (string.IsNullOrEmpty(_firstname))
                {
                    error = "First Name is required"; 
                }
                return error; 
            }
        }

        public string Error { get; private set; }
    }
}
