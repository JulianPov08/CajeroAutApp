using System;

namespace Transferencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajero cajero = new Cajero();
            cajero.Iniciar();
        }
    }

    class Cajero
    {
        public void Iniciar()
        {
            Console.WriteLine("Bienvenido al Cajero CriptoMoney");
            if (Autenticacion.Login())
            {
                Console.WriteLine("Inicio de sesión Realizado");
                Transferencia.RealizarTransferencia();
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }
    }

    static class Autenticacion
    {
        public static bool Login()
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su clave: ");
            string password = Console.ReadLine();
            return username == "Nequi" && password == "0809";
        }
    }

    static class Transferencia
    {
        public static void RealizarTransferencia()
        {
            Console.Write("Ingrese la cantidad que quieres transferir: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el número de cuenta del destinatario: ");
            string accountNumber = Console.ReadLine();

            Console.WriteLine($"Has transferido {amount:C} a la cuenta {accountNumber}.");
            Console.ReadKey();
        }
    }
}
