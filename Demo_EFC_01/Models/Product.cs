using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EFC_01.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
    }

    public class PerishableProduct : Product
    {
        public DateTime LimitDate { get; set; }
    }

    public class ClothingProduct : Product
    {
        public string Size { get; set; }
    }

}
