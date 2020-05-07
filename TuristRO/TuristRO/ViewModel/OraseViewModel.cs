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
        //crearea unei liste cu orase
        public ObservableCollection<OraseModels> ListCollector { get; set; }
        public OraseViewModel()
        {

            ListCollector = new ObservableCollection<OraseModels>()
            {    new OraseModels() {ID=1, Nume = "București", Descriere = "Unul dintre cele mai frumoase orașe din România, capitala țării noastre este totodată și una dintre cele mai importante metropole din Estul Europei", Imagine = "bucuresti.jpg" },
                 new OraseModels() {ID=2, Nume = "Iași", Descriere = "Cel mai semnificativ oraș din zona Moldovei, Iașul abundă în obiective turistice impresionante. Începe turul acestui oraș moldovenesc din Piața Unirii, unde poți admira clădiri vechi și hrăni porumbeii prietenoși.", Imagine = "iasi.jpg"},
                 new OraseModels() {ID=3, Nume = "Hunedoara", Descriere = "Oraşul de pe Valea Cernei, atestat documentar încă din anul 1265, este locul în care s-a dezvoltat, începând cu secolul al XIX-lea, o spiritualitate românească deosebită, cu numeroase biserici şi mânăstiri ctitorite în această perioadă. ", Imagine = "hunedoara.jpg" },
                 new OraseModels() {ID=4, Nume = "Brașov", Descriere = "Indiferent de anotimpul din an, Brașovul este unul dintre acele orașe frumoase din România, care te încântă de la prima întâlnire. ", Imagine = "brasov.jpg" },
                 new OraseModels() {ID=5, Nume = "Cluj-Napoca", Descriere = "Localizat în inima Transilvaniei, acest oraș se bucură de un decor natural spectaculos, fiind în același timp și o zonă culturală, cu multe evenimente care se organizează aici.", Imagine = "cluj2.jpg" },
                 new OraseModels() {ID=6, Nume = "Constanța", Descriere = "Situat în sud-estul României, Constanța este a treia zonă metropolitană din țară, un oraș amplasat fix la malul Mării Negre, care abundă de plaje și activități turistice deosebite pentru toți cei care iubesc marea.", Imagine = "constanta2.jpg" },
                 new OraseModels() {ID=7, Nume = "Suceava", Descriere = "Este unul dintre cele mai frumoase orase din regiunea istorică Moldova, aici regăsindu-se numeroase obiective turistice. Aici puteți descoperi mănăstiri vechi, cetăți medievale, stațiuni turistice renumite, dar și zone cu peisaje pitorești.", Imagine = "suceava.jpg" },
                 new OraseModels() {ID=8, Nume = "Sibiu", Descriere = "O bijuterie culturală și istorică amplasată chiar în inima țării. Aici regăsim o zonă cu un relief magnific și o regiune culturală cu o arhitectură specială.Sibiul este un spectacol vizual nemaipomenit, care atrage an de an turiști din toate colțurile lumii.", Imagine = "sibiu.jpg" },
                 new OraseModels() {ID=9, Nume = "Oradea", Descriere = "Capitală regională nemaipomenită, construită în mare parte în stilul baroc și art-nouveau. Centru cultural și educațional de mare prestigiu, Oradea are un trecut istoric bogat, este plin de clădiri și monumente arhitecturale clasice și totodată înconjurat de priveliști pitorești numai bune de fotografiat.", Imagine = "oradea.jpg" },
                 new OraseModels() {ID=10, Nume = "Alba-Iulia", Descriere = "Cu istorie milenară, rămâne un loc special din România, unde s-au scris file de istorie si s-au născut poveşti fascinante.", Imagine = "albaiulia2.jpg" },
                 new OraseModels() {ID=11, Nume = "Timișoara", Descriere = "În partea de Vest a țării, gasim unul dintre acele orașe frumoase din România de care este imposibil să nu te îndrăgostești. Oamenii calmi, prietenoși și zâmbitori adaugă un plus de valoare istoriei și bogăției culturale pe care le are acest oraș.", Imagine = "timisoara.jpg" },
                 new OraseModels() {ID=12, Nume = "Sighișoara", Descriere = "Sighișoara este cu siguranță o destinație care îți poate transforma vacanța într-o perioadă de vis. Este ultima cetate locuită a Europei și face parte din patrimoniul cultural UNESCO.", Imagine = "sighisoara.jpg" }
            };
            
        }
    }
}
