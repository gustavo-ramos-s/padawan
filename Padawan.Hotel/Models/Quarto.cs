using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.Hotel.Models

{
    public  class Quarto
    {
        public int Id { get; set; }
        public string NumeroQuarto { get; set; }
        public string AndarQuarto { get; set; }
        public bool Disponivel { get; set; }
     
    }
}
