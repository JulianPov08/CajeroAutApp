using System;


namespace CajeroCriptoMoney
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
                cajero.Deposit();
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }
    }

    class Cajero
    {
        private Usuario _usuario;

        public Cajero()
        {
            _usuario = new Usuario("Nequi", "0809");
        }

        public bool Login()
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su clave: ");
            string password = Console.ReadLine();
            return _usuario.Autenticar(username, password);
        }

        public void Deposit()
        {
            Console.Write("Ingrese la cantidad que vas a depositar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Has depositado {amount:C}.");

            Console.ReadKey();
        }
    }

    class Usuario
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Usuario(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool Autenticar(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}