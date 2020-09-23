using Microsoft.AspNetCore.Mvc;
using Padawan.Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.Hotel.Controllers
{
    [ApiController]
    [Route("Reserva")]
    public class ReservaController : ControllerBase
    {
        public static List<Reserva> minhaLista = new List<Reserva>();


        [HttpPost]
        [Route("AddReserva")]
        public ActionResult CadastroReserva(Reserva Reserva)
        {
            minhaLista.Add(Reserva);

            return Ok(minhaLista);
        }


        [HttpPost]
        [Route("BuscarReserva")]
        public ActionResult BuscarReserva(int IdHospede)
        {
            var result = minhaLista.Where(x => x.IdHospede == IdHospede).ToList();
            return Ok(result);
        }


        [HttpDelete]
        [Route("DeletarReserva")]
        public ActionResult DeleteReserva(int Id)
        {
            try
            {
                var result = minhaLista.RemoveAll(x => x.Id == Id);

                if (result == 0)
                    return BadRequest(Util.Message.Failure);
                else
                    return Ok(Util.Message.Success);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("UpdateReserva")]
        public ActionResult UpdateQuarto(int Reserva, int IdNovoQuarto)
        {
            var result = new Util.UtilResult.Result<List<Reserva>>();
            try
            {
                result.Data = minhaLista.Where(x => x.Id == Reserva).ToList();

                result.Data.Select(s =>
                {
                    s.IdQuarto = IdNovoQuarto;
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
