Console.WriteLine("============================================================"); // Encabezado
Console.WriteLine("    EJERCICIO 4 - CORRIENTE DE UN ACTUADOR ELÉCTRICO");       // Título
Console.WriteLine("============================================================"); // Encabezado

Console.WriteLine("Se realizarán ocho mediciones de corriente.");       // Planteamiento
Console.WriteLine("Corriente <= 5 A: MEDICIÓN NORMAL.");                 // Condición normal
Console.WriteLine("Corriente > 5 A: SOBRECORRIENTE DETECTADA.");        // Condición de sobrecorriente
Console.WriteLine("Se calculará el promedio y el resultado general.");  // Resultados

double suma = 0;          // Guarda la suma de las corrientes
int normales = 0;         // Cuenta las mediciones normales
int sobrecorrientes = 0;  // Cuenta las sobrecorrientes

for (int i = 1; i <= 8; i++) // Repite el proceso 8 veces
{
    Console.Write($"Ingrese la corriente #{i} (A): "); // Solicita la corriente

    double corriente = Convert.ToDouble(Console.ReadLine()); // Lee la corriente

    suma += corriente; // Acumula la corriente

    if (corriente <= 5) // Comprueba si es menor o igual a 5 A
    {
        Console.WriteLine("MEDICIÓN NORMAL"); // Muestra resultado normal
        normales++;                           // Aumenta el contador normal
    }
    else
    {
        Console.WriteLine("SOBRECORRIENTE DETECTADA"); // Muestra sobrecorriente
        sobrecorrientes++;                             // Aumenta el contador
    }
}

double promedio = suma / 8; // Calcula el promedio de las 8 mediciones

Console.WriteLine("============================================================"); // Separador
Console.WriteLine("                    RESULTADOS FINALES");                   // Título
Console.WriteLine("============================================================"); // Separador

Console.WriteLine($"Corriente promedio: {promedio:F2} A"); // Muestra promedio
Console.WriteLine($"Mediciones normales: {normales}");      // Muestra normales
Console.WriteLine($"Sobrecorrientes: {sobrecorrientes}");   // Muestra sobrecorrientes

if (sobrecorrientes == 0) // Comprueba si no hubo sobrecorrientes
{
    Console.WriteLine("ACTUADOR APROBADO"); // Resultado sin sobrecorrientes
}
else
{
    Console.WriteLine("EL ACTUADOR REQUIERE REVISIÓN"); // Hubo una o más
}

Console.ReadKey(); // Espera una tecla para cerrar