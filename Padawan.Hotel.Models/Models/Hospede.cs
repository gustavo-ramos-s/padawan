using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeClasses.Models
{
    public class Hospede
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public bool Ativo { get; set; }
        public int IdConsulta { get; set; }

        public virtual Reserva Consulta { get; set; }
    }
}