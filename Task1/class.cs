namespace Class
{
    class Order //присваевание имён переменным класса
    {
        private string customerName;
        private string address;
        private double amountSpent;

        public Order()
        {
            // Конструктор по умолчанию
        }

        public Order(string customerName, string address, double amountSpent) //упрощение имени класса
        {
            this.customerName = customerName;
            this.address = address;
            this.amountSpent = amountSpent;
        }

        

        //вывод адреса заказчика
        public void PrintCustomersByAddress(string targetAddress, List<Order> orders)
        {
            Console.WriteLine($"Заказчики по адресу {targetAddress}:");
            foreach (var order in orders)
            {
                if (order.address == targetAddress)
                {
                    Console.WriteLine(order.customerName);
                }
            }
        }

        //заказчики потратившие более (в нашем случае) 150 рублей
        public void PrintCustomersByAmount(double targetAmount, List<Order> orders)
        {
            Console.WriteLine($"Заказчики, потратившие больше {targetAmount} рублей:");
            foreach (var order in orders)
            {
                if (order.amountSpent > targetAmount)
                {
                    Console.WriteLine(order.customerName, order.amountSpent);
                }
            }
        }
    }
}