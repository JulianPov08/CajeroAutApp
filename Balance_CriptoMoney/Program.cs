using System;

using System;

namespace Balance_CriptoMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cajero CriptoMoney");

            Atm atm = new Atm();
            atm.Start();
        }
    }

    public class Atm
    {
        private User _user;
        private Account _account;

        public Atm()
        {
            _user = new User();
            _account = new Account();
        }

        public void Start()
        {
            if (_user.Login())
            {
                Console.WriteLine("Inicio de sesión realizado");
                _account.CheckBalance();
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }
    }

    public class User
    {
        private const string Username = "Nequi";
        private const string Password = "0809";

        public bool Login()
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su clave: ");
            string password = Console.ReadLine();
            return username == Username && password == Password;
        }
    }

    public class Account
    {
        private decimal _balance;

        public Account()
        {
            _balance = 500000.00m;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Tu saldo actual es de {_balance:C}.");
            Console.ReadKey();
        }
    }
}
