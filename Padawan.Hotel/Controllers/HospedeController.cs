using Microsoft.AspNetCore.Mvc;
using Padawan.Hotel.Models;
using Padawan.Hotel.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.Hotel.Controllers
{
    [ApiController]
    [Route("Hospede")]
    public class HospedeController : ControllerBase
    {
        public static List<Hospede> minhaLista = new List<Models.Hospede>();
        private readonly Hospede user;

        public HospedeController()
        {
            user = new Hospede();
        }

        [HttpPost]
        [Route("AddHospede")]
        public ActionResult CadastroHospede(Hospede Hospede)
        {

            try
            {
                if (user.ValidaCpf(Hospede.Cpf))
                {
                    minhaLista.Add(Hospede);
                    return Ok(minhaLista);
                }
                return BadRequest(Message.Failure);
            }
            catch (Exception ex)
            {
                return BadRequest($"{Message.Failure}{ex.Message}");
            }

        }

        [HttpPost]
        [Route("ListarHospedes")]
        public ActionResult ListarHospede(string Nome)
        {
            return Ok(minhaLista);
        }

        [HttpGet]
        [Route("BuscarHospede")]
        public ActionResult GetHospede(string nome, string sobrenome)
        {
            try
            {
                var result = minhaLista.Where(x => x.Nome.Contains(nome) && x.Sobrenome.Contains(sobrenome)).ToList();

                if (result.Count == 0)
                {
                    return BadRequest(Message.Failure);
                }
                else
                {
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                return NotFound($"{Message.Failure}{ex.Message}");
            }
        }

        [HttpDelete]
        [Route("DeletarHospede")]
        public ActionResult DeleteHospede(string nome, string sobrenome)
        {
            try
            {
                var result = minhaLista.RemoveAll(x => x.Nome == nome && x.Sobrenome == sobrenome);

                if (result == 0)
                    return BadRequest(Message.Failure);
                else
                    return Ok(Message.Success);
            }
            catch (Exception ex)
            {
                return BadRequest($"{Message.Failure}{ex.Message}");
            }
        }

        [HttpPut]
        [Route("UpdateHospede")]
        public ActionResult UpdateHospede(string cpfHospede, string NovoNome, string NovoSobrenome)
        {
            var result = new UtilResult.Result<List<Models.Hospede>>();
            try
            {
                result.Data = minhaLista.Where(x => x.Cpf == cpfHospede).ToList();
                result.Data.Select(n =>
                {
                    n.Nome = NovoNome;
                    return n;
                }).ToList();
                result.Data.Select(s =>
                {
                    s.Sobrenome = NovoSobrenome;
                    return s;
                }).ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Error = true;
                result.Message = ex.Message;
                return BadRequest(result);
            }
        }
    }
}