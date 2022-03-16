using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id{set; get; }
        public int Sortorder { set; get; }
        public bool ISShowonHome{set; get;}
        public int? ParentId { set; get; }
        public Status Status{set; get; }
    }
}
