using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TuristRO.Models;

namespace TuristRO.ViewModel
{
   public class EvenimenteViewModel
    {
        public ObservableCollection<EvenimenteModels> List3Collector { get; set; }
        public EvenimenteViewModel()
        {
            List3Collector = new ObservableCollection<EvenimenteModels>()
            {
                 new EvenimenteModels() {id=1, Nume = "Muzică", Imagine = "muzica.jpg" },
                 new EvenimenteModels() {id=2, Nume = "Film",  Imagine = "film.jpg" },
                 new EvenimenteModels() {id=3, Nume = "Teatru", Imagine = "teatru.jpg" },
                 new EvenimenteModels() {id=4, Nume = "Artă și cultură", Imagine = "Arta.jpg" }
            };
        }
    }
}
