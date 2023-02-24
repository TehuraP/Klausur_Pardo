using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythological_Animals
{
    class ViewModel : INotifyPropertyChanged
    {
        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<GodModel> GodData { get; set;  }

        private GodModel _ChosenGod;

        public GodModel ChosenGod
        {
            get { return _ChosenGod; }
            set { _ChosenGod = value; RaisePropertyChanged("ChosenGod"); }
        }
        public GodModel NewGod { get; set; }

        public ObservableCollection<MythModel> MythData { get; set; }
        public MythModel ChosenMyth { get; set; }


        MythContext _ctx = new MythContext();

        public void AddGod()
        {
            var neuerGott = new GodModel()
            {
                Description = NewGod.Description,
                Name = NewGod.Name,
            };


            //Zur DB hinzufügen
            //_ctx.Produkte.Add(NeuesProdukt);
            _ctx.listOfGods.Add(neuerGott);
            _ctx.SaveChanges();
            GodData.Add(neuerGott);


        }

        public void FillProdukteFromDB()
        {
           GodData = new ObservableCollection<GodModel>();
            foreach (GodModel produkt in _ctx.listOfGods)
            {
                GodData.Add(produkt);
            }
            
        }

        internal void DeleteProdukt()
        {
            var pDelete = _ctx.listOfGods.Find(ChosenGod.Name);

            _ctx.listOfGods.Remove(pDelete);
            _ctx.SaveChanges();
            //zur ObservableCollection hinzufügen
            GodData.Remove(ChosenGod);
            RaisePropertyChanged("Name");
            RaisePropertyChanged("Description");
        }

        public GodModel zeus { get; set; }
        
        
    }
}
