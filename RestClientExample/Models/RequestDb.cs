using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestClientExample.Models
{
    public class RequestDb:DbContext
    {
        public RequestDb()
                : base("DefaultConnection")
            {
            }
        public DbSet<Request> Requests { get; set; }

    }
}