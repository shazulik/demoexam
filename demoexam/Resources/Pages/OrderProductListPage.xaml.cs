using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace demoexam.Pages
{
   
    public partial class OrderProductListPage : Page
    {
        public OrderProductListPage()
        {
            InitializeComponent();
        }

        public OrderProductListPage(int index)
        {
            InitializeComponent();

            decimal resultCost = 0;
            List<HelpClass> listHelp = new();
            var listProduct = App.db.OrderProduct.Where(p => p.OrderId == index);
            foreach (var p in listProduct)
            {
                HelpClass helpClass = new HelpClass
                {
                    Article = p.OrderProductArticleNumber,
                    Name = p.OrderProductArticleNumberNavigation.ProductDescription,
                    Provider = p.OrderProductArticleNumberNavigation.ProductManufacturerNavigation.ManufacturerValue,
                    
                };
                listHelp.Add(helpClass);
            }
            dataGridOrderListProduct.ItemsSource = listHelp;

            foreach (var res in listHelp)
                
            textBlockResult.Text = String.Format("{0:C2}", resultCost);
        }
    }
}
