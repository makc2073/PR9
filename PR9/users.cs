using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace PR9
{
    [Table(Name = "users")]
    class users
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "user_id")]
        public int user_id { get; set; }
        [Column(Name = "first_name")]
        public string first_name { get; set; }
        [Column(Name = "last_name")]
        public string last_name { get; set; }
        [Column(Name = "created")]
        public DateTime created { get; set; }
        [Column(Name = "phone")]
        public string phone { get; set; }
        [Column(Name = "email")]
        public string email { get; set; }
    }
}
