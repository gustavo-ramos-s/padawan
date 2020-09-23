using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.Hotel.Models

{
    public class Reserva
    {
        public int Id { get; set; }
        public int IdQuarto { get; set; }
        public int IdHospede { get; set; }
        public DateTime? Data { get; set; }
        public string Pagamento { get; set; }
    }
}
