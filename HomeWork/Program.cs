using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Apple";
            product1.Tur = "Bilgisayar";
            product1.Fiyat = 14000;

            Product product2 = new Product();
            product2.Adi = "Apple";
            product2.Tur = "Tablet";
            product2.Fiyat = 12999;

            Product product3 = new Product();
            product3.Adi = "Apple";
            product3.Tur = "Saat";
            product3.Fiyat = 6500;

            Product[] products = new Product[] { product1, product2, product3 };
            
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Adi + ":" + products[i].Tur + ":" + products[i].Fiyat);
            }
            Console.WriteLine("for loop bitti.");
            
            foreach (var product in products)
            {
                Console.WriteLine(product.Adi + ":" + product.Tur + ":" + product.Fiyat);
            }
            Console.WriteLine("forech bitti.");

            //int j = products.Length - 1;
            //while (j>0)
            //{
            //    Console.WriteLine(products[j].Adi + ":" + products[j].Tur + ":" + products[j].Fiyat);
            //}
            //Console.WriteLine("while loop bitti");
        }
    }
}
