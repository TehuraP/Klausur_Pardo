using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythological_Animals
{
    class MythModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChangedEvent(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private string _Name;
  [Key]
        public string Name
        {
          
            get { return _Name; }
            set { _Name = value; RaisePropertyChangedEvent("Name"); }
        }

        private string _Photo;

        public string Photo
        {
            get { return _Photo; }
            set { _Photo = value; RaisePropertyChangedEvent("Photo"); }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; RaisePropertyChangedEvent("Description"); }
        }



    }
}
