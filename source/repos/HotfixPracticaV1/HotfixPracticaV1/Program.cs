namespace HotfixPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personaje = new Personaje
            {
                Nombre = "Guerrero",
                Vida = 100,
                Ataque = 1000545465454,
                Defensa = 15,
                Nivel = 3
            };

            Console.WriteLine("=== Datos del personaje ===");
            Console.WriteLine($"Nombre:  {personaje.Nombre}");
            Console.WriteLine($"Vida:    {personaje.Vida}");
            Console.WriteLine($"Ataque:  {personaje.Ataque}");
            Console.WriteLine($"Defensa: {personaje.Defensa}");
            Console.WriteLine($"Nivel:   {personaje.Nivel}");
        }
    }
}
