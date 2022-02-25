using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Api.Models
{
    [Table("Oficina")]
    public class Oficinas
    {
        public string OFI_NOMBRE { get; set; }
        public int OFI_CORRESPONSAL_ID { get; set; }
    }
}