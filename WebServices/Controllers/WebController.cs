using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class WebController : ApiController
    {
        private ReservationRepository repo = ReservationRepository.Current;
        [HttpGet]
        public IEnumerable<Reservation> GetAllReservations()
        {
            return repo.GetAll();
        }
        [HttpGet]
        public Reservation Get(int id)
        {
            return repo.Get(id);
        }
        [HttpPost]
        public Reservation CreateReservation(Reservation item)
        {
            return repo.Add(item);
        }
        [HttpPut]
        public bool UpdateReservation(Reservation item)
        {
            return repo.Update(item);
        }
        [HttpDelete]
        public void DeleteReservation(int id)
        {
            repo.Remove(id);
        }
    }
}