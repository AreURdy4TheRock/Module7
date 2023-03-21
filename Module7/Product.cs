namespace Module7
{

    class Product // Класс для выбора товара
    {
        protected string ProductName;
        public virtual string productName
        {
            get { return ProductName; }
            set
            {
                if (value != null)
                    ProductName = value;
            }
        }
        public string productDesc;
        public double productPrice;

        public virtual void ShowProduct() // Показывает товары в наличии
        {
            Console.WriteLine("Товар: {0}", productName);
            Console.WriteLine("Стоимость: {0}", productPrice);
            Console.WriteLine("Описание: {0}", productDesc);
        }

        public void ChangePrise(double newprise) // Меняет цену товара
        {
            productPrice = newprise;
        }

        public double DiscountPrise(double discount) // Вычисляет стоимость с учётом скидки
        {
            productPrice = productPrice - (productPrice * discount / 100);
            return productPrice;
        }

        public Product(string productName, string productDesc, double productPrice)
        {
            this.productName = productName;
            this.productDesc = productDesc;
            this.productPrice = productPrice;
        }
        public Product()
        {

        }

    }

    class Electronics : Product // Класс для электрических товаров
    {
        int voltage;
        public virtual string productName
        {
            get => base.ProductName;
            set
            {
                if (value != null && value.Length > 2)
                    ProductName = value;
                else
                {
                    Console.WriteLine("Некорректное имя");
                    ProductName = "Electro";
                }
            }
        }
        public override void ShowProduct()
        {
            base.ShowProduct();
            Console.WriteLine("Допустимое напряжение: {0}", voltage);

        }
        public Electronics(string productName, string productDesc, double productPrice, int voltage) : base(productName, productDesc, productPrice)
        {
            this.voltage = voltage;
        }
        public Electronics()
        {

        }
    }

    class Cloth : Product // Класс для одежды
    {
        int size;
        public virtual string productName
        {
            get => base.ProductName;
            set
            {
                if (value != null && value.Length > 2)
                    ProductName = value;
                else
                {
                    Console.WriteLine("Некорректное имя");
                    ProductName = "Cloth";
                }
            }
        }
        public override void ShowProduct()
        {
            base.ShowProduct();
            Console.WriteLine("Размер: {0}", size);
        }
        public Cloth(string productName, string productDesc, double productPrice, int size) : base(productName, productDesc, productPrice)
        {
            this.size = size;
        }
        public Cloth()
        {

        }
    }
}
