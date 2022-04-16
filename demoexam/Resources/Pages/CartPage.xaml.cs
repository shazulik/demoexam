using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace demoexam.Pages
{
    
    public partial class CartPage : Page
    {
        public int quantityInCart { get; set; }
        public decimal costWithQuantity { get; set; }
        public Product orderProduct { get; set; }

        public CartPage()
        {
            InitializeComponent();
        }

        public CartPage(List<Product> products)
        {
            InitializeComponent();
            dataGridProducts.ItemsSource = products.OrderBy(p => p.ProductName).Distinct();
            foreach (var p in products.OrderBy(p => p.ProductName).Distinct())
            {
                orderProduct = new Product
                {
                    OrderProductArticleNumber = p.productarticle,
                };
            }
        }

        private void buttonQuantityPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonQuantityMinus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}