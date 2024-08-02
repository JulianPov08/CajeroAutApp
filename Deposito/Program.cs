using System;

namespace Deposito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cajero CriptoMoney");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión Realizado");
                Deposit();
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
            Console.Write("Ingrese su clave: ");
            string password = Console.ReadLine();
            return username == "Nequi" && password == "0809";
        }

        static void Deposit()
        {
            Console.Write("Ingrese la cantidad que vas a depositar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Has depositado {amount:C}.");

            Console.ReadKey();
        }
    }
}