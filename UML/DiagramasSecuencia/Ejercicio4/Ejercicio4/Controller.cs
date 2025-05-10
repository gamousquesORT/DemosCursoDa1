namespace Ejercicio4;

public class Controller
{
    private string _name;

    public Controller(string name)
    {
        _name = name;
    }
    public void Execute()
    {

        Service service = new Service();
        service.ProcessData(_name);
        
        LogCompletion();
    }

    private void LogCompletion()
    {
        Console.WriteLine($"Proceso: {_name} ha completado.");
    }
}

public class Service
{
    public void ProcessData(string ctrlName)
    {
        Console.WriteLine($"Procesando datos...de Ctrl: {ctrlName}");
    }
}