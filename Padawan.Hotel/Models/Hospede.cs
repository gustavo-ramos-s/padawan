using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.Hotel.Models
{
    public class Hospede
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public bool Ativo { get; set; }

        public virtual Reserva Reserva { get; set; }
    }
}