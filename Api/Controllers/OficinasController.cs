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
    public class OficinasController : ApiController
    {
        public OficinasController()
        {
            
        }
        public List<OFICINAS> GetOficinas(int id)
        {
            using (DataContext.DataEntities _context = new DataContext.DataEntities())
            {
                var oficinas = _context.Database.SqlQuery<OFICINAS>(String.Format("SELECT * FROM OFICINAS WHERE OFI_CORRESPONSAL_ID = {0}", id)).ToList<OFICINAS>();
                return oficinas;
            }
        }
    }
}
