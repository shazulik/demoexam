using System;
using System.Collections.Generic;

namespace demoexam
{
    public partial class Product
    {
        internal object productarticle;

        public string Productarticle { get; set; } = null!;
        public string Productname { get; set; } = null!;
        public object ProductName { get; internal set; }
        public int Productunits { get; set; }
        public decimal Productprice { get; set; }
        public string Productsale { get; set; } = null!;
        public string Productsupplier { get; set; } = null!;
        public int Productprovider { get; set; }
        public int Productcategory { get; set; }
        public string Productcurrentdiscount { get; set; } = null!;
        public int Productquantityinstock { get; set; }
        public int Productdescription { get; set; }
        public byte[] ProductImage { get; set; } = null!;
        public int Productstatus { get; set; }
        public object OrderProductArticleNumber { get; internal set; }
    }
}
