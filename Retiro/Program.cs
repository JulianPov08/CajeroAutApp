using System;

namespace Retiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cajero CriptoMoney");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión Realizado");
                Withdraw();
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }

        static bool Login()
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su clave ");
            string password = Console.ReadLine();
            return username == "Nequi" && password == "0809";
        }

        static void Withdraw()
        {
            Console.Write("Ingrese la cantidad que quieres retirar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Has realizado un retiro {amount:C}.");

            Console.ReadKey();
        }
    }
}
