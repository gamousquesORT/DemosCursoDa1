using PersonDevices;

var person1 = new Person("5.555.345-1", "Nahuel");
var person2 = new Person("5.123.234-0", "Camila");

Cellphone cel1, cel2, cel3, cel4;

try
{
    cel1 = person1.AddCellphone("222-333-1234-44", "+59829021505");
    cel2 = person1.AddCellphone("123-222-3432-33", "+59829543434");
    cel3 = person2.AddCellphone("124-422-3432-35", "+5982883345");
    cel4 = person2.AddCellphone("124-422-3432-35", "+5982883345");
    
    // de quien es el celular
    Console.WriteLine($"Este celular es de {cel1.Owner.FullName}");
    Console.WriteLine($"Este celular es de {cel4.Owner.FullName}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
} 



