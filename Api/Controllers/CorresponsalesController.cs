using Api.DataContext;
using Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class CorresponsalesController : ApiController
    {
        public CorresponsalesController()
        {
        }
        // GET api/<controller>
        public List<CORRESPONSALES> GetCorresponsales()
        {
            using (DataContext.DataEntities _context = new DataContext.DataEntities())
            {
                return _context.CORRESPONSALES.ToList();
            }
        }
    }
}