// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


ICoffee coffee = new BasicCoffee();
Console.WriteLine($"{coffee.GetDescription()} costs {coffee.Cost():C}");
// Adding milk
coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} costs {coffee.Cost():C}");
// Adding sugar
coffee = new CreamDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} costs {coffee.Cost():C}");
// Adding another layer of milk
coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} costs {coffee.Cost():C}");

MilkDecorator ml = new MilkDecorator(coffee);
Console.WriteLine($"{ml.GetDescription()} costs {ml.Cost():C}");