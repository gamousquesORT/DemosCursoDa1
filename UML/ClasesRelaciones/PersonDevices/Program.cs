using PersonDevices;

var person1 = new Person("5.555.345-1", "Nahuel");
var person2 = new Person("5.123.234-0", "Camila");
try
{
    
    person1.AddCellphone("222-333-1234-44", "+59829021505");
    person2.AddCellphone("123-222-3432-33", "+59829543434");
    person2.AddCellphone("124-422-3432-35", "+5982883345");
    person2.AddCellphone("124-422-3432-35", "+5982883345");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
} 
var camiPhones = person2.CellphonesInfo();
for (int i = 0; i < camiPhones.Count(); i++)
{
    Console.WriteLine($"Cel:{i}, {camiPhones[i]}");
}
