using System;

namespace Balance_CriptoMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cajero CriptoMoney");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión Realizado");
                CheckBalance();
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

        static void CheckBalance()
        {
            
            decimal balance = 1000.00m; 
            Console.WriteLine($"Tu saldo actual es de {balance:C}.");
        }
    }
}
