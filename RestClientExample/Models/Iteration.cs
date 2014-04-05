using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestClientExample.Models
{
    [Table("Iteration")]
    public class Iteration
    {
        public int Id { get; set; }
        public string Argument1 { get; set; }
        public string Argument2 { get; set; }
        public Request Request { get; set; }
    }
}