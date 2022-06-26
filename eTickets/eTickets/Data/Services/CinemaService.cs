using System.Collections.Generic;
using System.Threading.Tasks;
using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemaService(AppDbContext context) : base(context)
        {
        }
    }
}