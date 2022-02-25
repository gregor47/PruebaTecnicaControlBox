using Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front.Interfaces
{
    public interface IServices
    {
        Task<List<Corresponsales>> GetCorresponsales();
        Task<List<Oficinas>> GetOficinas(string idOficina);
    }
}
