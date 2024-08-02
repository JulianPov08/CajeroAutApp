using System;

namespace Retiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cajero CriptoMoney");

            Cajero cajero = new Cajero();

            if (cajero.Login())
            {
                Console.WriteLine("Inicio de sesión realizado");
                cajero.Withdraw();
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }
    }

    class Cajero
    {
        private string usuario = "Nequi";
        private string clave = "0809";

        public bool Login()
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su clave: ");
            string password = Console.ReadLine();
            return username == usuario && password == clave;
        }

        public void Withdraw()
        {
            Console.Write("Ingrese la cantidad que quieres retirar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Has realizado un retiro de {amount:C}.");

            Console.ReadKey();
        }
    }
}

