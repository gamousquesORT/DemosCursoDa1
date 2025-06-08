using System;
using SingletonClassic.DTO;

namespace SingletonClassic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAppController ctrlOne = MyAppController.GetInstance(); 
            UserDTO dto = new UserDTO();
            dto.Name = "gaston";
            dto.ID = "1111111.1";
            ctrlOne.AddUser(dto);
            
            MyAppController ctrlTwo = MyAppController.Instance; //uso el método alternativo al GetInstance
            
            if (ctrlOne == ctrlTwo )
                Console.WriteLine("Sí, es igual. No importa cuantas veces llame a GetInstance() siempre va a devolver lo mismo");
 
            dto = new UserDTO();
            dto.Name = "María";
            dto.ID = "2111111.1";
            ctrlTwo.AddUser(dto);
        }
    }
}