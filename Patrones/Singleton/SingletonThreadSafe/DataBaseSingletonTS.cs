using System;

namespace SingletonThreadSafe
{
    public class Database
    {
        private static Lazy<Database> instance = new Lazy<Database>(() => new Database());
        private Database()
        {
            Console.WriteLine("Initializing database");
        }
        public string DataBaseName { get; set; }
        
        public static Database Instance => instance.Value;
    }
}