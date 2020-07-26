using System.Collections.Generic;
using System.Linq;
using shopapp.webui.Models;

namespace shopapp.webui.Data
{
    public static class ProductRepository//örnek oluşturmasın 1 tane olsun tek excel gibi
    {
        private static List<Product> _product=null;
        static ProductRepository(){
            _product=new List<Product>{
           new Product{ProductId=1, Name="Iphone 8", Price=3000,Description="İyi telefon",IsApproved=true,ImageUrl="1.jpg"},
           new Product{ProductId=2,Name="Iphone X", Price=6000,Description="Güzel telefon",IsApproved=true,ImageUrl="2.jpg"},
           new Product{ProductId=3,Name="Iphone 9", Price=6000,Description="Güzel telefon",IsApproved=false,ImageUrl="3.jpg"},
           new Product{ProductId=4,Name="Iphone 10", Price=6000,Description="Güzel telefon",ImageUrl="4.jpg"}
           };
           
        }

        public static List<Product> Products{
            get{
                return _product;
            }
        }

        public static void AddProduct(Product product){
            _product.Add(product);
        }
        public static Product GetProductById(int Id)
        {
        return _product.FirstOrDefault(i=>i.ProductId==Id);
        }




    }
}