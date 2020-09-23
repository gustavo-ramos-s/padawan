using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

        public bool ValidaCpf(string cpf)
        {
            Regex rx = new Regex(@"^([0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}$)");
            var retorno = rx.IsMatch(cpf);
            return retorno;
        }
    }
}

//[0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{2}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2}