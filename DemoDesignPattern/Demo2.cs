using System;

public interface IOrderFactory
{
    IOrder CreateOrder();
    IPayment CreatePayment();
    IShipping CreateShipping();
}

public interface IOrder
{
    void ProcessOrder();
}

public interface IPayment
{
    void ProcessPayment();
}

public interface IShipping
{
    void ShipOrder();
}

public class DomesticOrderFactory : IOrderFactory
{
    public IOrder CreateOrder()
    {
        return new DomesticOrder();
    }

    public IPayment CreatePayment()
    {
        return new DomesticPayment();
    }

    public IShipping CreateShipping()
    {
        return new DomesticShipping();
    }
}

public class InternationalOrderFactory : IOrderFactory
{
    public IOrder CreateOrder()
    {
        return new InternationalOrder();
    }

    public IPayment CreatePayment()
    {
        return new InternationalPayment();
    }

    public IShipping CreateShipping()
    {
        return new InternationalShipping();
    }
}

public class DomesticOrder : IOrder
{
    public void ProcessOrder()
    {
        Console.WriteLine("Processing domestic order...");
    }
}

public class InternationalOrder : IOrder
{
    public void ProcessOrder()
    {
        Console.WriteLine("Processing international order...");
    }
}

public class DomesticPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing domestic payment...");
    }
}

public class InternationalPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing international payment...");
    }
}

public class DomesticShipping : IShipping
{
    public void ShipOrder()
    {
        Console.WriteLine("Shipping domestic order...");
    }
}

public class InternationalShipping : IShipping
{
    public void ShipOrder()
    {
        Console.WriteLine("Shipping international order...");
    }
}

class Demo2
{
    public void Run()
    {
        IOrderFactory factory = new DomesticOrderFactory();

        IOrder order = factory.CreateOrder();
        IPayment payment = factory.CreatePayment();
        IShipping shipping = factory.CreateShipping();

        order.ProcessOrder();
        payment.ProcessPayment();
        shipping.ShipOrder();
        Console.WriteLine();
    }
}

