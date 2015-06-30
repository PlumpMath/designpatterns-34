using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using MVVM.Annotations;
using MVVM.Models;

namespace MVVM.ViewModels
{
   public class PersonViewModel : INotifyPropertyChanged
   {

       public PersonViewModel ()
       {
           LoadPerson(); 
       }

       private void LoadPerson()
       {
           ModelPerson = new Person
           {
               Id = 1,
               Firstname = "Max",
               Lastname = "Kimambo"
           }; 
           
       }



       private Person _modelPerson;

       public Person ModelPerson
       {
           get { return _modelPerson;  }
           set
           {
               _modelPerson = value;
               OnPropertyChanged("ModelPerson");
           }
       }



       public event PropertyChangedEventHandler PropertyChanged;

       [NotifyPropertyChangedInvocator]
       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
           PropertyChangedEventHandler handler = PropertyChanged;
           if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));


       }
    }
}
