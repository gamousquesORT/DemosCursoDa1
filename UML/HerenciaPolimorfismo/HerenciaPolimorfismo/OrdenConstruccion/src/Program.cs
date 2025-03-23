using ClaseAbstracta;

/*
 * Revise si la inicialización de los objetos es correcta. Si no lo es, corrija el código.
 */

var estudiate1 = new Estudiante();
Console.WriteLine($"Estudiante {estudiate1.Numero}  - CI: {estudiate1.Cedula} - Nombre: {estudiate1.Nombre}");

var estudiate2 = new Estudiante("Juan", "Portal", 200987);
Console.WriteLine($"Estudiante {estudiate2.Numero}  - CI: {estudiate2.Cedula} - Nombre: {estudiate2.Nombre}");