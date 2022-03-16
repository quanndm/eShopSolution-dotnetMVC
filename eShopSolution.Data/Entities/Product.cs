using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    //configure entity by attribute
    //[Table("Products")]
    public class Product
    {

        public int Id { set; get; }

        public decimal Price { set; get; }

        public decimal OriginalPrice { set; get; }

        public int Stock{set; get; }
        //[Required]
        public int ViewCount{set; get; }


        public DateTime DateCreate{set; get; }

        public string SeoAlias{set; get; }

    }
}
