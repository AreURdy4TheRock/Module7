using System.Threading;

namespace Module7
{

    abstract class Delivery // Класс для логики доставки
    {
        public string Address;
        public void ChooseDelivery()
        {
            Console.WriteLine("Выберите способ доставки.");
        }
    }

    class HomeDelivery : Delivery // Доставка на дом
    {
        public bool CourierAvailability;
        private static int DistanceToClient;
        private static int CourierReturn;
        public void CourierDelivery(int distance) // Метод доставки заказа
        {
            DistanceToClient = distance;
            CourierReturn = distance;
            if (CourierAvailability)
            {
                CourierAvailability = false;
                while (DistanceToClient != 0)
                {
                    DistanceToClient--;
                    Thread.Sleep(1000);
                    Console.WriteLine(DistanceToClient);
                }
                Console.WriteLine("Товар доставлен!");
            }
            else
            {
                Console.WriteLine("Курьер недоступен");
            }
            
            CourierColdown();
        }
        private void CourierColdown() // Метод возвращения курьера
        {
            while (CourierReturn != 0)
            {
                CourierReturn--;
                Thread.Sleep(1000);
                Console.WriteLine(CourierReturn);
            }
            Console.WriteLine("Курьер вернулся");
            CourierAvailability = true;
        }

    }

    class PickPointDelivery : Delivery // Доставка в пункт выдачи
    {
        private static int StorageTime;

        private void StorageDelivery() // Метод хранения товара в пункте доставки
        {
            if(StorageTime != 0)
            {
                while (StorageTime != 0)
                {
                    Thread.Sleep(1000);
                    StorageTime--;
                }
            }
            else
            {
                Console.WriteLine("Время хранения вышло. Товар удалён.");
            }
        }
    }

    class ShopDelivery : Delivery // Доставка в розничный магазин
    {
        public void BuyInShop()
        {
            Console.WriteLine("Добро пожаловать. Вот ваш товар!");
        }
    }

}
