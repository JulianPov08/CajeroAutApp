using System;

using System;

namespace Iniciando_Sesion
{
    class Program
    {
        static void Main(string[] args)
        {
            CajeroAutomatico cajero = new CajeroAutomatico();
            cajero.Iniciar();
        }
    }

    class CajeroAutomatico
    {
        private Usuario usuario;

        public CajeroAutomatico()
        {
            usuario = new Usuario("Nequi", "0809");
        }

        public void Iniciar()
        {
            Console.WriteLine("Bienvenido al Cajero CriptoMoney");
            if (usuario.IniciarSesion())
            {
                Console.WriteLine("Inicio de sesión Realizado");
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
            Console.ReadKey();
        }
    }

    class Usuario
    {
        private string Username { get; set; }
        private string Password { get; set; }

        public Usuario(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool IniciarSesion()
        {
            Console.Write("Ingrese su usuario: ");
            string usernameInput = Console.ReadLine();
            Console.Write("Ingrese su clave: ");
            string passwordInput = Console.ReadLine();

            return Username == usernameInput && Password == passwordInput;
        }
    }
}