using System;
using System.Collections.Generic;
using SingletonClassic.DTO;

namespace SingletonClassic
{
    // This basic example is not thread safe
    public sealed class MyAppController
    {
        // Notar que el atributo instance es Estático o sea de clase
        private static readonly MyAppController instance = new MyAppController();
        
        // Notar que la lista es un atributo de instancia (no tiene static)
        private List<User> _users;
        
        
        // Constructor estatico para inicializar atributos de clase
        static MyAppController()
        {
        }
        
        // Constructor de instancia privado - para que nadie haga new!!
        private MyAppController()
        {
            _users = new List<User>();
            Console.WriteLine("Initializing controller instance attributes");
        }
        
        // Método para obtener la única instancia que puede existir de MyAppController
        public static MyAppController GetInstance()
        {
            return instance;
        }

        // método alternativo al de arriba es solo otro forma de escrbir lo mismo
        public static MyAppController Instance => instance;

        //------------------------------------------------
        // Metodos específicos de la clase MyAppController
        //------------------------------------------------
        public void AddUser(UserDTO userData)
        {
            _users.Add(new User(userData.ID, userData.Name));
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
    }
}