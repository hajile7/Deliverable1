//Start via naming our variables
int sodaStock = 100;
int chipStock = 40;
int candyStock = 60;
int sodaRestock = 40;
int chipRestock = 20;
int candyRestock = 40;

//Welcome message
Console.WriteLine("Welcome to the restocking tool!");

//Currrent soda stock logic
Console.WriteLine("How many sodas have been sold today?");
int sodaCheck = int.Parse(Console.ReadLine());
while (sodaCheck > sodaStock)
{
    Console.WriteLine("The number is too high. Stock not adjusted. Please try again.");
    sodaCheck = int.Parse(Console.ReadLine());
}
int currentSoda = (sodaStock - sodaCheck);
Console.WriteLine("There are " + currentSoda + " cans of soda left.");

//Current chip stock logic
Console.WriteLine("How many bags of chips have been sold today?");
int chipCheck = int.Parse(Console.ReadLine());
while (chipCheck > chipStock)
{
    Console.WriteLine("The number is too high. Stock not adjusted. Please try again.");
    chipCheck = int.Parse(Console.ReadLine());
}
int currentChips = (chipStock - chipCheck);
Console.WriteLine("There are " + currentChips + " bags of chips left.");

//Current candy stock logic
Console.WriteLine("How many bags of candy have been sold today?");
int candyCheck = int.Parse(Console.ReadLine());
while (candyCheck > candyStock)
{
    Console.WriteLine("The number is too high. Stock not adjusted. Please try again.");
    candyCheck = int.Parse(Console.ReadLine());
}
int currentCandy = (candyStock - candyCheck);
Console.WriteLine("There are " + currentCandy + " bags of candy left.");

//Thank you message + restock logic
Console.WriteLine("Thank you for using the restocking tool. Here's what needs to be restocked:");
if (currentSoda <= sodaRestock)
{
    Console.WriteLine("Soda");
}
if (currentChips <= chipRestock)
{
    Console.WriteLine("Chips");
}
if (currentCandy <= candyRestock)
{
    Console.WriteLine("Candy");
}
else
{
    Console.WriteLine("nothing! :)");
}