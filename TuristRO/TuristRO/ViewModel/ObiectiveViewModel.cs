using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TuristRO.Models;

namespace TuristRO.ViewModel
{
  public  class ObiectiveViewModel
    {
        //crearea unei lista cu obiective
        public ObservableCollection<ObiectiveModels> List2Collector { get; set; }
        public ObiectiveViewModel()
        {
            List2Collector = new ObservableCollection<ObiectiveModels>()
            {    
                 new ObiectiveModels() {id=1, Nume = "Delta Dunării ", Descriere = "Este cea mai bine conservată deltă de pe continentul european", Imagine = "delta.jpg" },
                 new ObiectiveModels() {id=2, Nume = "Cascada Bigăr", Descriere = "Aflată în apropiere de localitatea Bozovici din județul Caraș-Severin, Bigar a devenit unul dintre principalele obiective turistice din Parcul Național Cheile Nerei-Beușnița, având una dintre cele mai spectaculoase căderi de apă din lume", Imagine = "bigar.jpg" },
                 new ObiectiveModels() {id=3, Nume = "Focul Viu", Descriere = "O arie protejată de interes național ce corespunde categoriei a III-a IUCN (rezervație naturală de tip mixt)", Imagine = "foculviu.jpg" },
                 new ObiectiveModels() {id=4, Nume = "Mocănița", Descriere = "Una dintre cele mai importante valori culturale şi tehnice ale țării, Mocănița de la Vişeu de Sus este ultima cale ferată forestieră cu abur din lume", Imagine = "mocanita.jpg" },
                 new ObiectiveModels() {id=5, Nume = "Transfăgărășan ", Descriere = "Drumul printre muntii Fagarasului, ce incepe din localitatea Bascov, judetul Arges si se termina in apropierea localitatii Cartisoara, judetul Sibiu.", Imagine = "transfagarasan.jpg" },
                 new ObiectiveModels() {id=6, Nume = "Lacul Sfânta ", Descriere = "În singurul lac vulcanic din Europa Centrală", Imagine = "sfana.jpg" },
                 new ObiectiveModels() {id=7, Nume = "Cimitirul Vesel ", Descriere = "Arta lemnului pe teritoriul Romaniei a atins conotatii creative de cea mai inalta calitatea, in zona Maramuresului", Imagine = "sapanta.jpg" },
                 new ObiectiveModels() {id=8, Nume = "Salina Turda", Descriere = "Un adevarat muzeu de istorie a mineritului în sare, la 30 de kilometri de Cluj și la câteva sute de metri sub pământ", Imagine = "turda.jpg" },
                 new ObiectiveModels() {id=9, Nume = "Cazanele Dunării", Descriere = " Una dintre cele mai frumoase zone de pe defileul Dunarii. Asezate la trecerea Dunarii prin muntii Carpati", Imagine = "cazanele.jpg" },
                 new ObiectiveModels() {id=10, Nume = "Castelul Peleș", Descriere = "Construit la iniţiativa primului Rege al României, Carol I, în afara perimetrului comunei Podul Neagului", Imagine = "peles.jpg" },
                 new ObiectiveModels() {id=11, Nume = "Cascada Cailor", Descriere = "Situată în apropiere de stațiunea turistică Borșa", Imagine = "cascada.jpg" }
            };
        }
    }
}
