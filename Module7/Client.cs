namespace Module7
{
    class Client //Клас для определения типа клиента (подросток, студент, взрослый, пенсионер)
    {
        public string ClientName;
        public int discount = 0;
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ((value > 18) && (value < 25)) 
                {
                    discount = 10; // Скидка для студента
                }
                if (value > 65)
                {
                    discount = 20; // Скидка для пенсионера
                }
                age = value;
            }
        }
        public virtual void Buy(string name) // Покупка товара
        {
            Console.WriteLine("Меня зовут {0}, Хочу приобрести {1}.", ClientName, name);

        }
        public void Greetings() // Приветствие клиента
        {
            Console.WriteLine("Добрый день, {0}", ClientName);
            Console.WriteLine("Наш Ассортимент:");
        }
        public void ChooseProduct() 
        {
            Console.WriteLine("Что хотите приобрести?");
        }
        public void ChooseDelivery()
        {
            Console.WriteLine("Выберите способ доставки:");
            Console.WriteLine("HomeDelivery");
            Console.WriteLine("PickPointDelivery");
            Console.WriteLine("ShopDelivery");
        }

    }

    class Student : Client // Класс для студента (скидка 10%)
    {
        public override void Buy(string name)
        {
            base.Buy(name);
            Console.WriteLine("Моя студенческая скидка {0}%", discount);
        }
    }
    
    class Pensioner : Client // Класс для пенсионера (скидка 20%)
    {
        public override void Buy(string name)
        {
            base.Buy(name);
            Console.WriteLine("Моя пенсионная скидка {0}%", discount);
        }
    }

    class Child : Client //Класс для подростка (никаких плюшек)
    {

    }

    class Adult : Client //Класс для взрослого человека (никаких плюшек)
    {

    }
}
