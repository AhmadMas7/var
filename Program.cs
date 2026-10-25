double price;
int quantity;
double total;
double allTotal = 0;
int choice = 1;
while (choice == 1)
{
    Console.WriteLine("Enter price");
    price = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter quntity:");
    quantity = Convert.ToInt32(Console.ReadLine());

    total = price * quantity;

    Console.WriteLine("Total = " + total);

    allTotal = allTotal + total;

    Console.WriteLine("Add another product? 1 = yes , 0 = no : ");
    choice = Convert.ToInt32(Console.ReadLine());


}

Console.WriteLine("All Total = " + allTotal);