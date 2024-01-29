using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Domain.Model
{
    public class ProductInProject
    {
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
    }
}
