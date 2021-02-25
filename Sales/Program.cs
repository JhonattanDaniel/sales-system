using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesMan seller1 = new SalesMan();
            seller1.Name = "Arturo Rojas";
            seller1.Age = 45;

            SalesMan seller2 = new SalesMan();
            seller2.Name = "Adriana Zuluaga";
            seller2.Age = 38;

            SalesMan seller3 = new SalesMan();
            seller3.Name = "Carlos Vallejo";
            seller3.Age = 41;

            Product p1 = new Product();
            p1.Name = "computer";
            p1.SetPrice(1000);

            Product p2 = new Product();
            p2.Name = "smartphone";
            p2.SetPrice(600) ;

            Product p3 = new Product();
            p3.Name = "smart tv";
            p3.SetPrice(900);


            Sale s1 = new Sale();
            s1.Product = p2;
            s1.SalesMan = seller1;
            s1.Comments = "Arturo sold a smartphone";


            Sale s2 = new Sale();
            s2.Product = p3;
            s2.SalesMan = seller2;
            s2.Comments = "Adriana sold a smart tv";

            Sale s3 = new Sale();
            s3.Product = p1;
            s3.SalesMan = seller3;
            s3.Comments = "Carlos sold a computer";

            double salesTotal = s1.Product.GetPrice() + s2.Product.GetPrice() + s3.Product.GetPrice();

            System.Console.WriteLine("Sales total acound US$" + salesTotal);
        }
    }
}
