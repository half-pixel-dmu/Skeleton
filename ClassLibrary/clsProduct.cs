using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsProduct
    {
        public int ProductNumber { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public DateTime ProductCreateDate { get; set; }
        public bool ProductAvailability { get; set; }
        public int StaffNo { get; set; }
    }
}
