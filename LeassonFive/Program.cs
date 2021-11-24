using LeassonFive;

Converter myConverter = new Converter(84.5, 100, 1.14);
Console.WriteLine(myConverter);

myConverter.BuyUSD(7355);
myConverter.SellUSD(100);

myConverter.BuyEUR(9316);
myConverter.SellEUR(93);

myConverter.BuyRUB(8655);
myConverter.SellRUB(1800);
