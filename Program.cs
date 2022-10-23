using InventoryMangment;

public class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\Gajanan\source\repos\InventoryMangment\InventoryMangment\Inventory.json";
        fetchdata F = new fetchdata();
        Inventory data = F.Read(path);
        Console.WriteLine("invetory details");
        //Console.WriteLine("**************");
        Console.WriteLine("Types of rice");
       for(int i = 0; i < data.typesofRice.Count; i++)
        {
            Console.WriteLine(data.typesofRice[i].name);
            Console.WriteLine(data.typesofRice[i].weight);
            Console.WriteLine(data.typesofRice[i].price);
            //int Price = data.typesofRice[i].weight * data.typesofRice[i].price;
            //Console.WriteLine("Total Price: " + Price);
        }
        Console.WriteLine("Types of rice");
        Console.WriteLine("**************");
        for (int i = 0; i < data.typesofPulses.Count; i++)
        {
            Console.WriteLine(data.typesofPulses[i].name);
            Console.WriteLine(data.typesofPulses[i].weight);
            Console.WriteLine(data.typesofPulses[i].price);
           // int Price = data.typesofPulses[i].weight * data.typesofPulses[i].price;
            //Console.WriteLine("Total Price: " + Price);
        }
        Console.WriteLine("**************");
        Console.WriteLine("Types of Weats");

        for (int i = 0; i < data.typesofWeats.Count; i++)
        {
            Console.WriteLine(data.typesofWeats[i].name);
            Console.WriteLine(data.typesofWeats[i].weight);
            Console.WriteLine(data.typesofWeats[i].price);
            //int Price = data.typesofWeats[i].weight * data.typesofWeats[i].price;
            //Console.WriteLine("Total Price: " + Price);
        }
    }
}