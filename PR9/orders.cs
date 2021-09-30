using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;



namespace PR9
{
    [Table(Name = "orders")]
    class orders
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "order_id")]
        public int order_id { get; set; }
        [Column(Name = "created")]
        public DateTime created { get; set; }
        [Column(Name = "user_ids")]
        public int user_ids { get; set; }
        [Column(Name = "point_ids")]
        public int point_ids { get; set; }

        [Column(Name = "sum")]
        public int sum { get; set; }
        [Column(Name = "status_ids")]
        public int status_ids { get; set; }
        [Column(Name = "delivery_sevice_ids")]
        public int delivery_sevice_ids { get; set; }       

    }
}
