using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TuristRO.Models
{
   public class FavoriteModels
    { 
          
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }
  

    }
}

