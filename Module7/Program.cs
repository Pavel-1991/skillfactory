namespace Module7
{
    abstract class Delivery
    {
        public string Address;
        public virtual void showDelivery()
        {
            Console.WriteLine("неопределённый тип доставки");
        }
        public Delivery(string address)
        {
            Address = address;
        }
    }

    class HomeDelivery : Delivery
    {
        protected string Сourier;
        public HomeDelivery(string сourier, string address) : base(address)
        {
            Сourier = сourier;
        }
        public override void showDelivery()
        {
            Console.WriteLine($"Доставка на дом по адресу:{Address}");
        }
    }

    class PickPointDelivery : Delivery
    {
        protected string NamePickPoint;
        public PickPointDelivery(string namePickPoint, string address) : base(address)
        {
            NamePickPoint = namePickPoint;
        }
        public override void showDelivery()
        {
            Console.WriteLine($"Доставка в пункт выдачи по адресу:{Address}");
        }
    }

    class ShopDelivery : Delivery
    {
        protected string NameShop;
        public ShopDelivery(string nameShop, string address) : base(address)
        {
            NameShop = nameShop;
        }
        public override void showDelivery()
        {
            Console.WriteLine($"Доставка в магазин по адресу:{Address}");
        }
    }

    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public Productlist Productlist;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
        public Order(TDelivery delivery, int number, string description, Productlist productlist)
        {
            Delivery = delivery;
            Number = number;
            Description = description;
            Productlist = productlist;
        }
    }
    class ForeignOrder<TDelivery> : Order<TDelivery> where TDelivery : Delivery
    {
        public string country;
        public ForeignOrder(string country, TDelivery delivery, int number, string description, Productlist productlist) : base(delivery, number, description, productlist)
        {
            this.country = country;
        }
    }

    class Product
    {
        public string Name;
        public int Quantity;
    }

    class Productlist
    {
        public Product[] list;

        public Productlist(Product[] list)
        {
            this.list = list;
        }
        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < list.Length)
                {
                    return list[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                if (index >= 0 && index < list.Length)
                {
                    list[index] = value;
                }
            }
        }

        public Product this[string name]
        {
            get
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i].Name == name)
                    {
                        return list[i];
                    }
                }
                return null;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HomeDelivery HomeDel = new HomeDelivery("Иванов И.И.", "рязань,праволыбедская 40");
            HomeDel.showDelivery();

            var array = new Product[]
            {
                new Product {Name = "Картошка", Quantity = 3},
                new Product {Name = "Лук", Quantity=2},
            };
            Productlist Nlist = new Productlist(array);
            Order<HomeDelivery> order1 = new Order<HomeDelivery>(HomeDel, 3, "Роллы", Nlist);
            order1.DisplayAddress();
            var Prod1 = Nlist["Картошка"].Quantity;
            Console.WriteLine(Prod1);
            string ProductName = "Лук";
            Console.WriteLine($"Количество товара {ProductName} в заказе № {order1.Number} = {order1.Productlist[ProductName].Quantity}");
        }
    }
}