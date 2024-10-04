using System;

public abstract class Car
{
    protected int basePrice = 0, onRoadPrice = 0;
    public string ModelName { get; set; }
    public int BasePrice
    {
        set => basePrice = value;
        get => basePrice;
    }
    public int OnRoadPrice
    {
        set => onRoadPrice = value;
        get => onRoadPrice;
    }
    public static int SetAdditionalPrice()
    {
        Random random = new Random();
        int additionalPrice = random.Next(200_000, 500_000);
        return additionalPrice;
    }
    public abstract Car Clone();
}
    public class Mustang : Car
    {
        public Mustang(string model) => (ModelName, BasePrice) = (model, 200_000);
        public override Car Clone() =>  this.MemberwiseClone() as Mustang;

    }
    public class Bentley : Car
    {
        public Bentley(string model) => (ModelName, BasePrice) = (model, 300_000);
        public override Car Clone() => this.MemberwiseClone() as Bentley;

    }
class Demo3
{
    public void Run()
    {
        Console.WriteLine("***Prototype Pattern Demo***\n");
        Car mustang = new Mustang("Mustang EcoBoost");
        Car bentley = new Bentley("Continental GT Mulliner");

        Console.WriteLine($"Car is: {mustang.ModelName}, and it's base price is Rs. {mustang.BasePrice}");
        Console.WriteLine($"Car is: {bentley.ModelName}, and it's base price is Rs. {bentley.BasePrice}");

        Car car;
        car = mustang.Clone();
        car.OnRoadPrice = car.BasePrice + Car.SetAdditionalPrice();
        Console.WriteLine($"Car is: {car.ModelName}, and it's price is Rs. {car.OnRoadPrice}");

        car = bentley.Clone();
        car.OnRoadPrice = car.BasePrice + Car.SetAdditionalPrice();
        Console.WriteLine($"Car is: {car.ModelName}, and it's price is Rs. {car.OnRoadPrice}");

        Console.WriteLine();
    }
}
    
