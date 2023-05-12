// See https://aka.ms/new-console-template for more information

using TrabajoPractico;

// Ropa miRopa = new Ropa();

Ropa miRopa = new Ropa("verde", "Masculino", "Cuero", "Remera", 19, "XL", false);

if (miRopa.TieneCapuchas())
{
    Console.WriteLine("Tiene capucha");
}
else
{
    Console.WriteLine("No tiene capucha");
}

Console.ReadKey();






