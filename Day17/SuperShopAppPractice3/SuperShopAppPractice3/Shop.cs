using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    public class Shop
    {
        public string Name { set; get; }
        public string Address { set; get; }
        public Product Product { set; get; }

        private List<Product> products;

        public Shop()
        {
            Product = new Product();
            products = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            if (products.Count>0)
            {
                foreach (var checkProduct in products)
                {
                    if (checkProduct.Id == product.Id)
                    {
                        checkProduct.Quantity += product.Quantity;
                        return true;
                    }
                }
            }
            products.Add(product);
            return true;
        }

        public string GetInfo()
        {
            string message = "";
            string shopinfo = "Name: " + Name + " Address: " + Address;
            string header = "product Id \t\t Quantity";
            string productInfo = "";

            //string productId = "";
            //string quantity = "";
            foreach (var product in products)
            {
                //productId = product.Id;
                //quantity = product.Quantity+"";
                productInfo += product.Id + " \t\t " + product.Quantity + " \n ";
            }

            message = shopinfo + "\n" + header + "\n" + productInfo;
            return message;

            //return $"{Name} \t\t {Address} \t\t {productId} \t {quantity} ";
        }
























        //public void AddItem(Product product)
        //{
        //    CheckProduct(product);
        //}

        //private void CheckProduct(Product product)
        //{
        //    if (products.Contains(product))
        //    {
        //        int index = products.IndexOf(product);

        //        products.Insert(index, product);
        //    }
        //    else
        //    {
        //        products.Add(product);
        //    }
        //}

        //public string ShowDetails()
        //{
        //    string message = "";
        //    foreach (Product product in products)
        //    {
        //        message += product.GetInfo() + Environment.NewLine;
        //    }

        //    return message;
        //}
    }
}
