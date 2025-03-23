using System.Security.Cryptography;
using ClaseAbstracta;
/*
* uso de clase abstracta
*/

// var personaError = new Persona(); // esto no compila

//Empleado
var empleado = new Empleado();
empleado.Nombre = "Romina";
empleado.NumeroEmpleado = "123";
empleado.ImprimirNombre();
empleado.ImrimirDescripcion();
empleado.MetodoSinEnlaceDinamico();

Console.WriteLine("--------------------------------------------------\n");
//EmpleadoMensual
var empleadoMensual = new EmpleadoMensual();
empleadoMensual.Nombre = "Ramiro";
empleadoMensual.NumeroEmpleado = "456";
empleadoMensual.ImprimirNombre();
empleadoMensual.ImrimirDescripcion();
empleadoMensual.MetodoSinEnlaceDinamico();
Console.WriteLine("--------------------------------------------------\n");

//EmpleadoDiario
var empleadoDiario = new EmpleadoDiario();
empleadoDiario.Nombre = "Raquel";
empleadoDiario.NumeroEmpleado = "789";
empleadoDiario.ImprimirNombre();
empleadoDiario.ImrimirDescripcion();
empleadoDiario.MetodoSinEnlaceDinamico();

Console.WriteLine("--------------------------------------------------\n");
Persona otroEmpleado = new EmpleadoMensual();
otroEmpleado.Nombre = "Otro";
otroEmpleado.ImprimirNombre();
otroEmpleado.MetodoSinEnlaceDinamico(); //qué metodo se ejecuta? el de Empleado o el de Persona?
