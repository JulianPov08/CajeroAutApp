using System;

namespace Transferencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cajero CriptoMoney");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión Realizado");
                Transfer();
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

        static void Transfer()
        {
            Console.Write("Ingrese la cantidad que quieres transferir: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el número de cuenta del destinatario: ");
            string accountNumber = Console.ReadLine();

            Console.WriteLine($"Has echo un transferido {amount:C} a la cuenta {accountNumber}.");
            Console.ReadKey();
        }
    }
}
