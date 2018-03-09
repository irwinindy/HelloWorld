using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldApi.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Today { get; set; }
        public bool Active { get; set; }
    }
}