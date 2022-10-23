using Decorator;

var pizzaBase = new MediumPizza();

var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);
Console.WriteLine($"mediumPizzaWithCheese price: {mediumPizzaWithCheese.CalculatePrice()}");

var mediumPizzaWithCheeseAndSalami = new SalamiPizzaDecorator(mediumPizzaWithCheese);
Console.WriteLine($"mediumPizzaWithCheeseAndSalami price: {mediumPizzaWithCheeseAndSalami.CalculatePrice()}");

var mediumPizzaWithCheeseAndDoubleSalami = new SalamiPizzaDecorator(mediumPizzaWithCheeseAndSalami);
Console.WriteLine($"mediumPizzaWithCheeseAndDoubleSalami price: {mediumPizzaWithCheeseAndDoubleSalami.CalculatePrice()}");