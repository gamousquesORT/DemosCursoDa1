
using VehicleInheritance;

// notar las distintas formas de llamar a los constructores
Car toyotaCar = new Car { Maker = "Toyota", Model = "Corolla", Id = "scc-3", Doors = 4 };
Motorcycle hondaMotorcycle = new Motorcycle( "Honda", "CBR", "scd-3456", false);

Console.WriteLine("\n------------ car ------------");
Console.WriteLine("Car: " + toyotaCar.Maker + " model=" + toyotaCar.Model + " id" + toyotaCar.Id + " doors" + toyotaCar.Doors);

// que resultado daría el drive?
toyotaCar.Drive();

Console.WriteLine("------------ motorcycle ------------"); 
Console.WriteLine("Motorcycle: " + hondaMotorcycle.Maker + " model:" + hondaMotorcycle.Model + " id" + hondaMotorcycle.Id + " Sidecar" + hondaMotorcycle.Sidecar);

// que resultado daría el drive?
hondaMotorcycle.Drive();

Console.WriteLine("\nCualquier tecla para continuar");
Console.ReadKey();

Console.WriteLine("\n------------ Revisar Salida ------------");
Vehicle vehicleOne = new Car("Lamborgini", "Diablo", "abb-1234", 2);
Vehicle vehicleTwo = new Motorcycle("Harley-Davidson", "highway king", "abd-333", true);

Console.WriteLine("------------ car ------------");
Console.WriteLine("Car: " + vehicleOne.Maker + " model:" + vehicleOne.Model + " id:" + vehicleOne.Id);
//Console.WriteLine("Car: " + vehicleOne.Maker + " model:" + vehicleOne.Model + " id:" + vehicleOne.Id + " doors:" + vehicleOne.Doors);

// que resultado daría el drive?
vehicleOne.Drive();

Console.WriteLine("------------ motorcycle ------------"); 
Console.WriteLine("Motorcycle: " + vehicleTwo.Maker + " " + vehicleTwo.Model + " " + vehicleTwo.Id);
//Console.WriteLine("Motorcycle: " + vehicleTwo.Maker + " model:" + vehicleTwo.Model + " id:" + vehicleTwo.Id + " sidecar:" + vehicleTwo.Sidecar);
vehicleTwo.Drive();



