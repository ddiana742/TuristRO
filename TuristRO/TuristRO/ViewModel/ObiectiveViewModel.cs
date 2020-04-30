using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TuristRO.Models;

namespace TuristRO.ViewModel
{
  public  class ObiectiveViewModel
    {
        public ObservableCollection<ObiectiveModels> List2Collector { get; set; }
        public ObiectiveViewModel()
        {
            List2Collector = new ObservableCollection<ObiectiveModels>()
            {
                 new ObiectiveModels() { Nume = "Cascada Cailor", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "cascada.jpg" },
                 new ObiectiveModels() { Nume = "Lacul Sfanta ", Descriere = "în singurul lac vulcanic din Europa Centrală", Imagine = "sfana.jpg" },
                 new ObiectiveModels() { Nume = "Mănăstirea Voroneț ", Descriere = "situată în apropiere de stațiunea turistică Borșa", Imagine = "voronet.jpg" },
                 new ObiectiveModels() { Nume = "Delta Dunării ", Descriere = "este cea mai bine conservată deltă de pe continentul european", Imagine = "delta.jpg" },
                 new ObiectiveModels() { Nume = "Transfăgărășan ", Descriere = "drumul printre muntii Fagarasului, ce incepe din localitatea Bascov, judetul Arges si se termina in apropierea localitatii Cartisoara, judetul Sibiu.", Imagine = "transfagarasan.jpg" },
                new ObiectiveModels() { Nume = "Cascada Bigăr", Descriere = "Aflată în apropiere de localitatea Bozovici din județul Caraș-Severin, Bigar a devenit unul dintre principalele obiective turistice din Parcul Național Cheile Nerei-Beușnița, având una dintre cele mai spectaculoase căderi de apă din lume", Imagine = "bigar.jpg" },
                 new ObiectiveModels() { Nume = "Cimitirul Vesel ", Descriere = "Arta lemnului pe teritoriul Romaniei a atins conotatii creative de cea mai inalta calitatea, in zona Maramuresului", Imagine = "sapanta.jpg" },
                new ObiectiveModels() { Nume = "Salina Turda", Descriere = "un adevarat muzeu de istorie a mineritului în sare, la 30 de kilometri de Cluj și la câteva sute de metri sub pământ", Imagine = "turda.jpg" },
                 new ObiectiveModels() { Nume = "Cazanele Dunării", Descriere = " una dintre cele mai frumoase zone de pe defileul Dunarii. Asezate la trecerea Dunarii prin muntii Carpati", Imagine = "cazanele.jpg" },
                 new ObiectiveModels() { Nume = "Castelul Peleș", Descriere = "construit la iniţiativa primului Rege al României, Carol I, în afara perimetrului comunei Podul Neagului", Imagine = "peles.jpg" },
                 new ObiectiveModels() { Nume = "Mocănița", Descriere = "Una dintre cele mai importante valori culturale şi tehnice ale țării, Mocănița de la Vişeu de Sus este ultima cale ferată forestieră cu abur din lume", Imagine = "mocanita.jpg" }






            };
        }
    }
}
