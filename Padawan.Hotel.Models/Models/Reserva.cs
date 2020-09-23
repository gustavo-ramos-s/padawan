using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeClasses.Models

{
    public class Reserva
    {
        public int Id { get; set; }
        public int IdDentista { get; set; }
        public int IdPaciente { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? HoraMarcada { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
    }
}
