using System;
using System.Diagnostics;

namespace Module7
{
    
    internal class Program
    {

        
        static void Main(string[] args)
        {
            
            Electronics electronics = new Electronics();
            Cloth clotgh = new Cloth();
            Order<Delivery> order = new Order<Delivery>();
            HomeDelivery homeDelivery = new HomeDelivery();
            homeDelivery.CourierAvailability = true;
            PickPointDelivery pickPointDelivery = new PickPointDelivery();
            ShopDelivery shopDelivery = new ShopDelivery();
            String word;
            Student student = new Student { ClientName = "Art", Age = 22 };
            student.Greetings();
            order.product.ShowProduct();
            order.electronics.ShowProduct();
            order.cloth.ShowProduct();
            student.ChooseProduct();
            word = Console.ReadLine();
            if (word == "Electro")
            {
                student.Buy(order.electronics.productName);
                order.Choose(order.electronics.productName, order.electronics.productPrice);
            }
            order.Price = order.electronics.DiscountPrise(student.discount);
            Rubles rubles = new Rubles(order.Price, order.currency);
            order.ShowOrder();

            student.ChooseDelivery();
            word = Console.ReadLine();
            if (word == "HomeDelivery")
            {
                homeDelivery.CourierDelivery(10);
            }

            Console.ReadKey();
            
        }
    }
}