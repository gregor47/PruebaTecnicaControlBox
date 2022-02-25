using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Corresponsales
    {
        [Key]
        public int COR_CORRESPONSAL_ID { get; set; }
        public string COR_NOMBRE { get; set; }
    }
}