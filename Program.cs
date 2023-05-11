namespace c41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person persona = new Person("5820082", "Karla", 29, 'f');
            persona.GenerarDNI();
            EstadoPeso estado = persona.CalcularIMC(peso: 56, altura: 1.56);
            Console.WriteLine("El estado de peso es: {0}", estado);
            persona.ListarInfo();

            Person persona2 = new Person("482932", "Lian", 29, 'X');
            persona2.GenerarDNI();
            EstadoPeso estado2 = persona2.CalcularIMC(peso: 50, altura: 1.91);
            Console.WriteLine("El estado de peso es: {0}", estado2);
            persona2.ListarInfo();




        }
    }

}