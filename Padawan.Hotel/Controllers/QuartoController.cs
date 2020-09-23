using Microsoft.AspNetCore.Mvc;
using Padawan.Hotel.Models;
using Padawan.Hotel.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.Hotel.Controllers
{
    [ApiController]
    [Route("Quarto")]
    public class QuartoController : ControllerBase
    {
        public static List<Quarto> minhaLista = new List<Quarto>();

        [HttpPost]
        [Route("AddQuarto")]
        public ActionResult CadastroQuarto(Quarto Quarto)
        {
            minhaLista.Add(Quarto);

            return Ok(minhaLista);
        }

        [HttpPost]
        [Route("ListarQuarto")]
        public ActionResult ListarQuarto(string Nome)
        {
            return Ok(minhaLista);
        }


      

        [HttpGet]
        [Route("BuscarQuarto")]
        public ActionResult PesquisarQuarto(string Quarto)
        {
            var result = new Util.UtilResult.Result<List<Quarto>>();
            try
            {
                result.Data = minhaLista.Where(x => x.NumeroQuarto.Contains(Quarto)).ToList();

                if (result.Data.Count == 0)
                {
                    return BadRequest(Message.Failure);
                }
                else
                {
                    return Ok(Message.Success);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{Message.Failure}{ex.Message}");
            }
        }

        [HttpDelete]
        [Route("DeletarQuarto")]
        public ActionResult DeleteQuarto(string Quarto)
        {
            try
            {
                var result = minhaLista.RemoveAll(x => x.NumeroQuarto == Quarto);

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
        [Route("UpdateQuarto")]
        public ActionResult UpdateQuarto(string Quarto, string NovoQuarto)
        {
            var result = new Util.UtilResult.Result<List<Quarto>>();
            try
            {
                result.Data = minhaLista.Where(x => x.NumeroQuarto == Quarto).ToList();

                result.Data.Select(s =>
                {
                    s.NumeroQuarto = NovoQuarto;
                    return s;
                }).ToList();

                return Ok(Message.Success);
            }
            catch (Exception ex)
            {
                return BadRequest($"{Message.Failure}{ex.Message}");
            }

        }
    }
}

