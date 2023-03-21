namespace Module7
{

    class Order<TDelivery> where TDelivery : Delivery // Класс для оформления заказа
    {
        public TDelivery Delivery;

        public int Number;
        public double Price;
        public string Description;
        public string currency = "руб.";

        public void DisplayAddress() // Показывает адрес доставки
        {
            Console.WriteLine(Delivery.Address);
        }

        public void Choose(string description, double price) // Выбрать товар
        {
            Number++;
            Description = description;
            Price = price;
        }
        public void ShowOrder() // Показать товар
        {

            Console.WriteLine("Ваш номер заказа {0}", Number);
            Console.WriteLine("{0} за {1} {2}", Description, Price, currency);
        }
        // Композиция
        public Product product;
        public Electronics electronics;
        public Cloth cloth;
        public Order()
        {
            product = new Product("Prod", "Nice", 100);
            electronics = new Electronics("Electro", "Cool", 200, 220);
            cloth = new Cloth("Cloth", "Good", 300, 50);

        }

    }

}

