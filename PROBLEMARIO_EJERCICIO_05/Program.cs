Console.WriteLine("============================================================"); // Encabezado
Console.WriteLine("       EJERCICIO 5 - ANÁLISIS DE VIBRACIÓN");              // Título
Console.WriteLine("============================================================"); // Encabezado
Console.WriteLine("Se analizarán varios motores con 4 mediciones.");         // Planteamiento
Console.WriteLine("Promedio <= 4.5 mm/s: FUNCIONAMIENTO NORMAL.");          // Condición normal
Console.WriteLine("Promedio > 4.5 mm/s: EL MOTOR REQUIERE MANTENIMIENTO."); // Condición

int totalMotores = 0;         // Cuenta todos los motores
int motoresNormales = 0;      // Cuenta motores normales
int motoresMantenimiento = 0; // Cuenta motores con mantenimiento
bool continuar = true;        // Controla el ciclo while

while (continuar) // Repite mientras se quieran analizar motores
{
    Console.Write($"Ingrese el nombre del motor #{totalMotores + 1}: "); // Pide nombre
    string nombreMotor = Console.ReadLine() ?? ""; // Guarda el nombre

    double suma = 0; // Reinicia la suma para cada motor

    for (int i = 1; i <= 4; i++) // Repite 4 mediciones
    {
        Console.Write($"Ingrese vibración #{i} (mm/s): "); // Solicita medición
        double vibracion = Convert.ToDouble(Console.ReadLine()); // Lee medición

        suma += vibracion; // Acumula la vibración
    }

    double promedio = suma / 4; // Calcula el promedio

    Console.WriteLine($"Motor: {nombreMotor}"); // Muestra el motor
    Console.WriteLine($"Vibración promedio: {promedio:F2} mm/s"); // Muestra promedio

    if (promedio <= 4.5) // Comprueba si está dentro del límite
    {
        Console.WriteLine("FUNCIONAMIENTO NORMAL DEL MOTOR"); // Resultado normal
        motoresNormales++; // Aumenta contador
    }
    else
    {
        Console.WriteLine("EL MOTOR REQUIERE MANTENIMIENTO"); // Resultado
        motoresMantenimiento++; // Aumenta contador
    }

    totalMotores++; // Aumenta total de motores

    Console.Write("¿Desea analizar otro motor? (S/N): "); // Pregunta si continúa
    string respuesta = (Console.ReadLine() ?? "").ToUpper(); // Lee respuesta

    if (respuesta == "N") // Comprueba si desea terminar
        continuar = false; // Termina el while
}

Console.WriteLine("============================================================"); // Separador
Console.WriteLine("                    RESULTADOS FINALES");                   // Título
Console.WriteLine("============================================================"); // Separador

Console.WriteLine($"Total de motores evaluados: {totalMotores}"); // Total
Console.WriteLine($"Motores normales: {motoresNormales}"); // Normales
Console.WriteLine($"Motores que requieren mantenimiento: {motoresMantenimiento}"); // Mantenimiento

Console.ReadKey(); // Espera una tecla