using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeClasses.Models

{
    public  class Quarto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string CRO { get; set; }
        public List<Reserva> Agenda { get; set; } = new List<Reserva>();
    }
}
