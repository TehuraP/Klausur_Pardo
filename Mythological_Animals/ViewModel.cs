﻿using System;
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
        public ObservableCollection<GodModel> GodData { get; set; }
        public ObservableCollection<GodModel> GodDataFromCode { get; set; }

        private GodModel _ChosenGod;

        public GodModel ChosenGod
        {
            get { return _ChosenGod; }
            set { _ChosenGod = value; RaisePropertyChanged("ChosenGod"); }
        }
        public GodModel NewGod { get; set; }
        public MythModel NewMyth { get; set; }

        public ObservableCollection<MythModel> MythData { get; set; }

        public ObservableCollection<MythModel> MythDataFromCode { get; set; }
        public MythModel _ChosenMyth { get; set; }

        public MythModel ChosenMyth
        {
            get { return _ChosenMyth; }
            set { _ChosenMyth = value; RaisePropertyChanged("ChosenMyth"); }
        }

        public ObservableCollection<MythModel> MythDataFromCode2 { get; set; }

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

        public void AddMyth()
        {
            var newMyth = new MythModel()
            {
                Description = NewMyth.Description,
                Name = NewMyth.Name,
            };

            //Zur DB hinzufügen
            //_ctx.Produkte.Add(NeuesProdukt);
            _ctx.listOfMyths.Add(newMyth);
            _ctx.SaveChanges();
            MythData.Add(newMyth);
        }


        public void FillGodsFromDB()
        {
            GodData = new ObservableCollection<GodModel>();
            foreach (GodModel produkt in _ctx.listOfGods)
            {
                GodData.Add(produkt);
            }

        }

        public void FillMythsFromDB()
        {
            MythData = new ObservableCollection<MythModel>();
            foreach (MythModel myth in _ctx.listOfMyths)
            {
                MythData.Add(myth);
            }

        }

        internal void DeleteItem()
        {
            var pDelete = _ctx.listOfGods.Find(ChosenGod.Name);
            if (ChosenGod.Name != null)
            {
                _ctx.listOfGods.Remove(pDelete);
                _ctx.SaveChanges();
                //zur ObservableCollection hinzufügen
                GodData.Remove(ChosenGod);
                RaisePropertyChanged("Name");
                RaisePropertyChanged("Description");
            }


        }
    }
}
