using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestClientExample.Models
{
     [Table("Request")]
    public class Request
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlBase { get; set; }
        public string Action { get; set; }

    }
}