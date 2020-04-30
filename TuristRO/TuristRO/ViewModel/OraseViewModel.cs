using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TuristRO.Meniu;
using TuristRO.Models;

namespace TuristRO.ViewModel
{
   public class OraseViewModel
    {
        public ObservableCollection<OraseModels> ListCollector { get; set; }
        public OraseViewModel()
        {

            ListCollector = new ObservableCollection<OraseModels>()
            {
                 new OraseModels() {ID=1, Nume = "Alba-Iulia", Descriere = "Cu istorie milenară, rămâne un loc special din România, unde s-au scris file de istorie si s-au născut poveşti fascinante.", Imagine = "alba.jpg" },
                 new OraseModels() {ID=2, Nume = "Sibiu", Descriere = "situată în apropiere de Sibiu", Imagine = "sibiu.jpg" },
                 new OraseModels() {ID=3, Nume = "Constanța", Descriere = "situată în apropiere de Constanta", Imagine = "constanta.jpg" },
                 new OraseModels() {ID=4, Nume = "Brașov", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "brasov.jpg" },
                 new OraseModels() {ID=5, Nume = "Cluj-Napoca", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "cluj.jpg" },
                 new OraseModels() {ID=6, Nume = "Hunedoara", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "hunedoara.jpg" },
                 new OraseModels() {ID=7, Nume = "Suceava", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "suceava.jpg" },
                 new OraseModels() {ID=8, Nume = "Iași", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "iasi.jpg"},
                 new OraseModels() {ID=9, Nume = "Oradea", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "oradea.jpg" },
                 new OraseModels() {ID=10, Nume = "București", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "bucuresti.jpg" },
                 new OraseModels() {ID=11, Nume = "Timișoara", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "timisoara.jpg" },
                 new OraseModels() {ID=12, Nume = "Sighișoara", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "sighisoara.jpg" }
            };
            
        }
    }
}
