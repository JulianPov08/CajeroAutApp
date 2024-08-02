using System;

namespace Iniciando_Sesion 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cajero CriptoMoney");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión Realizado");

            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");

            }
            Console.ReadKey();
        }

        static bool Login()
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su clave ");
            string password = Console.ReadLine();
            
            return username == "Nequi" && password == "0809";
            Console.ReadKey();
        }
    }
}