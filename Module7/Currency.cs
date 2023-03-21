namespace Module7
{
    abstract class Currency // Класс для валюты
    {
        public double ConvertPrice; //цена в валюте (по умолчанию в рублях)
        public Currency(double price)
        {
            ConvertPrice = price;
        }
    }
    class Rubles : Currency // Цена в валюте
    {
        private string CurrencyProduct;   
        public Rubles(double prise, string currency) : base(prise)
        {
            CurrencyProduct = currency;
        }
    }
    class Dollars : Currency // Цена в долларах
    {
        private string CurrencyProduct;
        public Dollars(double prise, string currency) : base(prise)
        {
            CurrencyProduct = currency;
        }
        public double ConvertToDollars(double price) // Конвертация рубли -> доллары
        {
            ConvertPrice = price / 65;
            return ConvertPrice;
        }
    }
    class Euro : Currency // Цена в евро
    {
        private string CurrencyProduct;

        public Euro(double prise, string currency) : base(prise)
        {
            CurrencyProduct = currency;
        }
        public double ConvertToEuro(double price) // Конвертация рубли -> евро
        {
            ConvertPrice = price / 82;
            return ConvertPrice;
        }
    }
}
