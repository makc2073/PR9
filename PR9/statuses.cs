using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace PR9
{
    [Table(Name = "statuses")]
    class statuses
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "status_id")]
        public int status_id { get; set; }
        [Column(Name = "status_name")]
        public string status_name { get; set; }
        [Column(Name = "code")]
        public int code { get; set; }
        [Column(Name = "color_ids")]
        public int color_ids { get; set; }
    }
}
