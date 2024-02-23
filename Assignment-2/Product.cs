using System;


namespace ProductClass
{
    //base class product
    class Product
    {
        //properties
        public int productId;
        public string productName;
        public double price;

        //constructor
        public Product(int productId, string productName, double price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }
    }

    //PhysicalProduct class inherits from Product
    class PhysicalProduct: Product
    {
        //construtor
        public PhysicalProduct(int  productId, string productName, double price) : base(productId, productName, price) { }

        //method to calculate shipping cost for physical products
        public void  CalculateShippingCost()
        {
            double shippingCost = price * 0.1; //10% of price
            Console.WriteLine("The shipping cost of physical product is " + shippingCost);
        }
    }

    class DigitalProduct : Product
    {
        //constructor
        public  DigitalProduct(int  productId, string productName, double price) : base(productId, productName, price) { }

        //method to display download link for digital product
        public void DisplayDownloadLink()
        {
            Console.WriteLine("Download link for " + productName + ": https://siemens.com/download/" + productId);
        }
    }
    

}
